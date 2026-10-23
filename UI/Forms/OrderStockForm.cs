using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class OrderStockForm : BaseForm
    {
        private readonly IOrderStockReservationService _orderStockReservationService;
        private readonly IStockOnHandService _stockOnHandService;
        private readonly IOrderLineService _orderLineService;
        private readonly IItemService _itemService;
        private readonly IOrderService _orderService;
        private int _orderLineId, _orderItemId, _selectedStockId, _orderlineItemCount;
        private bool _isUpdating = false;
        private readonly DataTable _orderStockTable = new DataTable();
        public OrderStockForm(int orderLineId, IOrderStockReservationService orderStockReservationService, IStockOnHandService stockOnHandService, IOrderLineService orderLineService, IItemService itemService, IOrderService orderService)
        {
            InitializeComponent();
            formName = "Sipariş Stok Girişi";
            formImg = "dashboards/addquery";

            _orderLineId = orderLineId;
            _orderStockReservationService = orderStockReservationService;
            _stockOnHandService = stockOnHandService;
            _orderLineService = orderLineService;
            _itemService = itemService;
            _orderService = orderService;

            _orderStockTable.Columns.Add("id", typeof(int)).DefaultValue = 0;
            _orderStockTable.Columns.Add("orderlineid", typeof(int)).DefaultValue = 0;
            _orderStockTable.Columns.Add("stockid", typeof(int)).DefaultValue = 0;
            _orderStockTable.Columns.Add("batchnumber", typeof(string)).DefaultValue = "";
            _orderStockTable.Columns.Add("itemcount", typeof(int)).DefaultValue = 0;
            _orderStockTable.Columns.Add("selectedcount", typeof(int)).DefaultValue = 0;
            _orderStockTable.Columns.Add("deleted", typeof(string)).DefaultValue = "";
            _orderStockTable.Columns.Add("remainingstockcount", typeof(int)).DefaultValue = 0;
            _orderStockTable.DefaultView.RowFilter = "deleted <> 'd'";

        }
        
        protected override void SaveData()
        {
            try
            {
                SaveReservation();
                MessageBox.Show("Siparişe stok ekleme işlemi başarılı bir şekilde gerçekleşti", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void ListData()
        {
            _orderItemId = Convert.ToInt32(_orderLineService.TGetById(_orderLineId).itemid);
            var Item = _itemService.TGetById(_orderItemId);
            txtItemName.Text = Item.name;
            txtItemCode.Text = Item.itemcode;

            var orderline = _orderLineService.TGetById(_orderLineId);
            int orderId = Convert.ToInt32(_orderService.TGetById(orderline.orderid).id);
            var order = _orderService.TGetById(orderId);
            txtOrderCode.Text = order.ordercode;

            _orderlineItemCount = orderline.itemcount;
            LoadOrderStock(_orderLineId);
        }
        protected override void UpdateData()
        {
            try
            {
                SaveReservation();
                MessageBox.Show("Siparişte stok güncelleme işlemi başarılı bir şekilde gerçekleşti", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void DeleteData()
        {
            SelectedRowDelete();
            MessageBox.Show("Siparişe stok silme işlemi başarılı bir şekilde gerçekleşti", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected override void CloseWindow()
        {
            this.Close();
        }
        private void SelectedRowDelete()
        {
            if (GVList.FocusedRowHandle < 0)
            {
                return;
            }

            var row = GVList.GetDataRow(GVList.FocusedRowHandle);
            if (row == null)
            {
                return;
            }

            if (row.RowState == DataRowState.Added)
            {
                row.Delete();
            }
            else
            {
                int stockId = Convert.ToInt32(row["stockid"]);
                int count = Convert.ToInt32(row["selectedcount"]);

                var entity = new orderstockreservation
                {
                    id = Convert.ToInt32(row["id"]),
                    orderlineid = _orderLineId,
                    stockid = stockId,
                    selectedcount = count,
                    deleted = "d"
                };
                _orderStockReservationService.TUpdate(entity);

                var stock = _stockOnHandService.TGetById(stockId);
                stock.itemcount += count;
                _stockOnHandService.TUpdate(stock);

                row["deleted"] = "d";
                row.AcceptChanges();
            }

            txtRequiredItemCount.Text = CalculateRequiredItemCount(_orderlineItemCount).ToString();
        }
        private int CalculateRequiredItemCount(int itemcount)
        {
            return Math.Max(0, itemcount - TotalItemCount());
        }
        private void SaveReservation()
        {
            GVList.CloseEditor();
            GVList.UpdateCurrentRow();

            foreach (DataRow row in _orderStockTable.Rows)
            {
                if (row.RowState != DataRowState.Added)
                {
                    continue;
                }

                int stockid = Convert.ToInt32(row["stockid"]);
                int count = Convert.ToInt32(row["selectedcount"]);

                var stock = _stockOnHandService.TGetById(stockid);
                if (stock != null)
                {
                    if (stock.itemcount < count)
                    {
                        MessageBox.Show("Stok yetersiz. Güncel stok: " + stock.itemcount);
                        return;
                    }
                }
                _orderStockReservationService.TAdd(new orderstockreservation
                {
                    orderlineid = _orderLineId,
                    stockid = stockid,
                    selectedcount = count,
                    deleted = row["deleted"]?.ToString()
                });
                stock.itemcount -= count;
                _stockOnHandService.TUpdate(stock);
            }
            _orderStockTable.AcceptChanges();
            LoadOrderStock(_orderLineId);
        }
        private void LoadOrderStock(int orderLineId)
        {
            _orderStockTable.Rows.Clear();

            if (orderLineId != 0)
            {
                var stocks = _stockOnHandService.TGetAll().Where(s => s.itemid == _orderItemId).ToDictionary(s => s.id);
                foreach (var osreservation in _orderStockReservationService.TGetAll().Where(o => o.orderlineid == orderLineId))
                {
                    string batchnumber = "";
                    int itemcount = 0;
                    int remainingcount = 0;
                    if (stocks.TryGetValue(osreservation.stockid, out var stock))
                    {
                        batchnumber = stock.batchnumber;
                        itemcount = stock.itemcount+osreservation.selectedcount;
                        remainingcount = stock.itemcount;
                    }
                     
                    _orderStockTable.Rows.Add(osreservation.id, osreservation.orderlineid, osreservation.stockid, batchnumber, itemcount, osreservation.selectedcount,"",remainingcount);
                }
            }
            _orderStockTable.AcceptChanges();
            GCList.DataSource = _orderStockTable;
            txtRequiredItemCount.Text = CalculateRequiredItemCount(_orderlineItemCount).ToString();
        }
        private int TotalItemCount(int excludeRowHandle = -1)
        {
            int total = 0;
            for (int i = 0; i < GVList.DataRowCount; i++)
            {
                if (i == excludeRowHandle) continue;
                object v = GVList.GetRowCellValue(i, "selectedcount");
                if (v != null && v != DBNull.Value)
                    total += Math.Max(0, Convert.ToInt32(v));
            }
            return total;
        }

        private void repoBtnBatchNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var popUpForm = new PopUpForm<stockonhand>(_stockOnHandService.TGetAll().Where(s => s.itemid == _orderItemId).ToList(), "Ürün Stok Seçimi"))
            {
                if (popUpForm.ShowDialog() == DialogResult.OK)
                {
                    _selectedStockId = popUpForm._id;
                }
            }

            if (_selectedStockId == 0)
            {
                return;
            }

            var stock = _stockOnHandService.TGetById(_selectedStockId);

            GVList.SetRowCellValue(GVList.FocusedRowHandle, "stockid", _selectedStockId);
            GVList.SetRowCellValue(GVList.FocusedRowHandle, "batchnumber", stock.batchnumber);
            GVList.SetRowCellValue(GVList.FocusedRowHandle, "itemcount", stock.itemcount);
        }

        private void OrderStockForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void GVList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                BeginInvoke(new Action(() => GVList.AddNewRow()));
            }
        }

        private void repoBtnOrderStockDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteData();
        }

        private void GVList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != "selectedcount" || _isUpdating)
            {
                return;
            }
            _isUpdating = true;
            try
            {
                int selectedCount = Convert.ToInt32(GVList.GetRowCellValue(e.RowHandle, "selectedcount"));
                int stockCount = Convert.ToInt32(GVList.GetRowCellValue(e.RowHandle, "itemcount"));

                int othertotal = TotalItemCount(e.RowHandle);
                int remainingForRow = _orderlineItemCount - othertotal;

                int maxCount = Math.Max(0, Math.Min(stockCount, remainingForRow));
                int fixedCount = Math.Min(Math.Max(0, selectedCount), maxCount);

                if (fixedCount != selectedCount)
                {
                    GVList.SetRowCellValue(e.RowHandle, "selectedcount", fixedCount);
                }
                GVList.SetRowCellValue(e.RowHandle, "remainingstockcount", stockCount - fixedCount);

                txtRequiredItemCount.Text = Math.Max(0, _orderlineItemCount - othertotal - fixedCount).ToString();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        private void GVList_ShowingEditor(object sender, CancelEventArgs e)
        {
            var row = GVList.GetDataRow(GVList.FocusedRowHandle);
            if (row == null)
                return;

            if (row.RowState == DataRowState.Unchanged)
            {
                e.Cancel = true;
            }
        }
    }
}
