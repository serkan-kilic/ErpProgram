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
    public partial class OrderStockForm : Form
    {
        //orderservice gerek yok çünkü veriyi burada kaydetmiyeceğimiz 
        //bu formda kayıt işlemi yapılmayacak constructerda gelen dictionarye satırları kayıt edilecek dictionarynin key'ide 
        //mesela bi kalemde 2 farklı parti stocktan girildi bu durumda p1,p2 diye artacak diğer bir kalemde ise p3,p4 diye devam edicek keyler
        private readonly IOrderStockReservationService _orderStockReservationService;
        private readonly IStockOnHandService _stockOnHandService;
        private readonly IOrderLineService _orderLineService;
        private readonly IItemService _itemService;
        private int _orderLineId, _orderItemId, _requiredItemCount;
        private bool _isUpdating = false;
        private readonly DataTable _orderStockTable = new DataTable();
        private Dictionary<string, orderstockreservation> _itemData;
        public OrderStockForm(Dictionary<string, orderstockreservation> itemData, int selectedItemId, int orderlineId, int requiredItemCount, IOrderStockReservationService orderStockReservationService, IStockOnHandService stockOnHandService, IOrderLineService orderLineService, IItemService itemService)
        {
            InitializeComponent();

            _orderStockReservationService = orderStockReservationService;
            _stockOnHandService = stockOnHandService;
            _orderLineService = orderLineService;
            _itemService = itemService;
            _orderItemId = selectedItemId;
            _orderLineId = orderlineId;
            _requiredItemCount = requiredItemCount;

            _itemData = itemData; //Dictionary

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

        private void ListData()
        {
            var Item = _itemService.TGetById(_orderItemId);
            txtRequiredItemCount.Text = _requiredItemCount.ToString();
            txtItemName.Text = Item.name;
            txtItemCode.Text = Item.itemcode;

            _orderStockTable.Rows.Clear();

            var stocks = _stockOnHandService.TGetAll().Where(s => s.itemid == _orderItemId);
            var reservations = _orderStockReservationService.TGetAll().Where(o => o.orderlineid == _orderLineId).ToList();
            foreach (var stock in stocks)
            {
                var res = reservations.FirstOrDefault(o => o.stockid == stock.id);
                bool data = _itemData.TryGetValue(stock.batchnumber, out var cachedata);
                if (res != null)
                {
                    _orderStockTable.Rows.Add(res.id, res.orderlineid, res.stockid, stock.batchnumber, stock.itemcount + res.selectedcount, res.selectedcount, "", stock.itemcount);
                }
                else if (data)
                {
                    _orderStockTable.Rows.Add(cachedata.id, cachedata.orderlineid, cachedata.stockid, stock.batchnumber, stock.itemcount , cachedata.selectedcount, "", stock.itemcount-cachedata.selectedcount);
                }
                else if (stock.itemcount > 0)
                {
                    _orderStockTable.Rows.Add(0, 0, stock.id, stock.batchnumber, stock.itemcount, 0, "", stock.itemcount);
                }
            }

            _orderStockTable.AcceptChanges();
            GCList.DataSource = _orderStockTable;
            txtRequiredItemCount.Text = Math.Max(0, _requiredItemCount - TotalItemCount()).ToString();
        }
        private void CloseWindow()
        {
            this.Close();
        }
        private int TotalItemCount(int excludeRowHandle = -1)
        {
            int total = 0;
            for (int i = 0; i < GVList.DataRowCount; i++)
            {
                if (i == excludeRowHandle)
                {
                    continue;
                }

                object v = GVList.GetRowCellValue(i, "selectedcount");

                if (v != null && v != DBNull.Value)
                {
                    total += Math.Max(0, Convert.ToInt32(v));
                }
            }
            return total;
        }
        private void OrderStockForm_Load(object sender, EventArgs e)
        {
            ListData();
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
                int remainingForRow = _requiredItemCount - othertotal;

                int maxCount = Math.Max(0, Math.Min(stockCount, remainingForRow));
                int fixedCount = Math.Min(Math.Max(0, selectedCount), maxCount);

                if (fixedCount != selectedCount)
                {
                    GVList.SetRowCellValue(e.RowHandle, "selectedcount", fixedCount);
                }
                GVList.SetRowCellValue(e.RowHandle, "remainingstockcount", stockCount - fixedCount);

                txtRequiredItemCount.Text = Math.Max(0, _requiredItemCount - othertotal - fixedCount).ToString();
            }
            finally
            {
                _isUpdating = false;
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtRequiredItemCount.Text) > 0)
            {
                MessageBox.Show($"{txtRequiredItemCount.Text} Adet eksik ürün girişi var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < GVList.DataRowCount; i++)
                {
                    int id = 0;
                    id = Convert.ToInt32(GVList.GetRowCellValue(i, "id"));
                    var selectedCount = Convert.ToInt32(GVList.GetRowCellValue(i, "selectedcount"));
                    var batchNumber = GVList.GetRowCellValue(i, "batchnumber")?.ToString();
                    if (batchNumber == null)
                    {
                        continue;
                    }
                    var stockId = Convert.ToInt32(GVList.GetRowCellValue(i, "stockid"));
                    orderstockreservation row = new orderstockreservation();

                    bool check = _itemData.TryGetValue(batchNumber, out var checker); //itemdatanın içine daha önce eklenip eklendiğini kontrol ediyor
                    if (selectedCount <= 0 && id == 0 && check)
                    {
                        continue;
                    }

                    if (check)
                    {
                        checker.selectedcount = selectedCount;
                        continue;
                    }
                    if (id > 0)
                    {
                        row.id = id;
                        row.stockid = stockId;
                        row.orderlineid = Convert.ToInt32(GVList.GetRowCellValue(i, "orderlineid"));
                        row.selectedcount = selectedCount;
                        row.deleted = GVList.GetRowCellValue(i, "deleted").ToString();
                    }
                    else
                    {
                        row.id = 0;
                        row.stockid = stockId;
                        row.orderlineid = 0;
                        row.selectedcount = selectedCount;
                        row.deleted = "";
                    }
                    _itemData.Add(batchNumber, row);

                }
                CloseWindow();
            }
        }

        private void BtnDecline_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
    }
}
