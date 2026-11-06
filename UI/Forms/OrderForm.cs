using Business.Abstract;
using DataAccess.Abstract;
using DevExpress.Mvvm.POCO;
using DevExpress.Office.Utils;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraSpreadsheet.Layout;
using Entities.concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows.Forms;
using DevExpress.DataAccess.Native.ExpressionEditor;

namespace UI.Forms
{
    public partial class OrderForm : BaseForm
    {
        //detay sayfasında sipariş ürün düzenleme kısmı olmiyacak yeni ürünleri direkt gridviewdan eklenicek button propertisi varmış
        //ve kaydete basılana kadar order ve orderline a veri kaydedilmiyecek istersek tek seferde 10 veri kaydetebiliriz 
        //gridviewda düzenle olmiyacak

        //ordercode rastgele üretilecek ve değiştirilemeyecek.

        //orderlineda stok girşi yapıp save etmediğim veriyi silip tekrar ekleyince datada veri kaldığı için tekrar ekldiğimde verinin stokgirişi dolu oluyor bunu düzelt
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IOrderTypeService _orderTypeService;
        private readonly IOrderStatusService _orderStatusService;
        private readonly ICustomerService _customerService;
        private readonly IItemService _itemService;
        private readonly IOrderLineService _orderlineService;
        private readonly IStockOnHandService _stockOnHandService;
        private readonly IOrderStockReservationService _orderStockReservationService;
        private int selectedCustomerId, selectedEditCustomerId, selectedOrderId;
        public Dictionary<string, orderstockreservation> data = new Dictionary<string, orderstockreservation>();
        private DataTable _orderLineTable = CreateOrderLineTable();
        private readonly List<orderstockreservation> _changedItemReservations = new List<orderstockreservation>();

        public OrderForm(IOrderService orderService, IPaymentService paymentService, IOrderTypeService orderTypeService, IOrderStatusService orderStatusService, ICustomerService customerService, IItemService itemService, IOrderLineService orderLineService, IStockOnHandService stockOnHandService, IOrderStockReservationService orderStockReservationService)
        {
            InitializeComponent();
            formName = "Satış Sipariş Yönetim";
            formImg = "edit/paste";

            _orderService = orderService;
            _paymentService = paymentService;
            _orderTypeService = orderTypeService;
            _orderStatusService = orderStatusService;
            _customerService = customerService;
            _itemService = itemService;
            _orderlineService = orderLineService;
            _stockOnHandService = stockOnHandService;

            gCOrderLineList.DataSource = _orderLineTable;
            _orderStockReservationService = orderStockReservationService;
        }
        private static DataTable CreateOrderLineTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("id", typeof(int)).DefaultValue = 0;
            dt.Columns.Add("orderid", typeof(int)).DefaultValue = 0;
            dt.Columns.Add("itemid", typeof(int)).DefaultValue = 0;
            dt.Columns.Add("itemcode", typeof(string)).DefaultValue = "";
            dt.Columns.Add("unitprice", typeof(decimal)).DefaultValue = 0m;
            dt.Columns.Add("itemcount", typeof(int)).DefaultValue = 0;
            dt.Columns.Add("itemtotalprice", typeof(decimal)).DefaultValue = 0m;
            dt.Columns.Add("deleted", typeof(string)).DefaultValue = "";
            dt.DefaultView.RowFilter = "deleted <> 'd'";
            return dt;
        }


        protected override void SaveData()
        {
            try
            {
                CheckStock();
                var saveData = GetOrderFromForm();
                _orderService.TAdd(saveData);
                _selectedId = saveData.id;
                SaveOrderLines(saveData.id);
                MessageBox.Show("Sipariş başarılı bir şekilde eklendi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void ListData()
        {
            var orderService = _orderService.TGetAll();
            var paymentService = _paymentService.TGetAll();
            var orderTypeService = _orderTypeService.TGetAll();
            var orderStatusService = _orderStatusService.TGetAll();
            var customerService = _customerService.TGetAll();
            var itemService = _itemService.TGetAll();

            GCList.DataSource = orderService;
            LUPaymentType.Properties.DataSource = paymentService;
            LUOrderType.Properties.DataSource = orderTypeService;
            LUOrderStatus.Properties.DataSource = orderStatusService;
            LUEPaymentType.Properties.DataSource = paymentService.Where(x => x.id != 1);
            LUEOrderType.Properties.DataSource = orderTypeService.Where(x => x.id != 1);
            LUEOrderStatus.Properties.DataSource = orderStatusService.Where(x => x.id != 1);
            repoLUTCKN.DataSource = customerService;
            repoLUVKN.DataSource = customerService;
            repoLUPayment.DataSource = paymentService;
            repoLUOrderStatus.DataSource = orderStatusService;
            repoLUOrderType.DataSource = orderTypeService;
            repoLUOrder.DataSource = orderService;

        }
        protected override void UpdateData()
        {
            try
            {
                CheckStock();
                var updateData = GetOrderFromForm();
                _orderService.TUpdate(updateData);
                SaveOrderLines(updateData.id);
                MessageBox.Show("Sipariş başarılı bir şekilde güncellendi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void DeleteData()
        {
            var deleteData = GetOrderFromForm().id;
            if (deleteData > 0)
            {
                _orderService.TDeleteOrderWithLines(deleteData);
                MessageBox.Show("Sipariş başarılı bir şekilde silindi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silmek için bir sipariş seçmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void ClearData()
        {
            _selectedId = 0;
            selectedCustomerId = 0;
            selectedEditCustomerId = 0;
            selectedOrderId = 0;

            btnOrderCode.Clear();
            btnTCKNVKN.Clear();
            BtnEditTCKNVKN.Clear();
            txtCompletedDate.Clear();
            txtEditOrderDate.Clear();
            txtOrderTotalPrice.Clear();
            LUEOrderStatus.Clear();
            LUEOrderType.Clear();
            LUEPaymentType.Clear();
            LUOrderStatus.Clear();
            LUOrderType.Clear();
            LUPaymentType.Clear();

            txtEditOrderCode.Text = GenerateRandomCode();
            LoadOrderLines(0);
            data.Clear();
            _changedItemReservations.Clear();
            ListData();
        }
        protected override void CloseWindow()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
        protected override void FilterData()
        {
            var query = _orderService.TGetQueryable();

            if (btnTCKNVKN.EditValue != null && btnTCKNVKN.Text.Trim() != "")
            {
                query = query.Where(x => x.customerid == selectedCustomerId);
            }
            if (btnOrderCode.EditValue != null && btnOrderCode.Text.Trim() != "")
            {
                query = query.Where(x => x.id == selectedOrderId);
            }
            if (LUOrderStatus.EditValue != null && Convert.ToInt32(LUOrderStatus.EditValue) > 0)
            {
                query = query.Where(x => x.orderstatusid == Convert.ToInt32(LUOrderStatus.EditValue));
            }
            if (LUOrderType.EditValue != null && Convert.ToInt32(LUOrderType.EditValue) > 0)
            {
                query = query.Where(x => x.ordertypeid == Convert.ToInt32(LUOrderType.EditValue));
            }
            if (LUPaymentType.EditValue != null && Convert.ToInt32(LUPaymentType.EditValue) > 0)
            {
                query = query.Where(x => x.paymentid == Convert.ToInt32(LUPaymentType.EditValue));
            }
            GCList.DataSource = query.ToList();
        }

        private int LUEValueReader(LookUpEdit lue)
        {
            int id = 0;
            if (lue.EditValue != null)
            {
                id = Convert.ToInt32(lue.EditValue);
            }
            return id;
        }
        private void LoadOrderLines(int orderId)
        {
            _orderLineTable = CreateOrderLineTable();

            if (orderId != 0)
            {
                var items = _itemService.TGetAll().ToDictionary(x => x.id);

                foreach (var l in _orderlineService.TGetAll().Where(x => x.orderid == orderId))
                {
                    string code = "";
                    decimal price = 0;

                    if (items.TryGetValue(l.itemid, out var item))
                    {
                        code = item.itemcode;
                        price = item.unitprice;
                    }

                    _orderLineTable.Rows.Add(l.id, l.orderid, l.itemid, code, price, l.itemcount, l.itemtotalprice, "");

                    var orderstockreservations = _orderStockReservationService.TGetAll().Where(o => o.orderlineid == l.id);
                    foreach (var osr in orderstockreservations)
                    {
                        var stock = _stockOnHandService.TGetAll().FirstOrDefault(s => s.id == osr.stockid);
                        if (stock == null)
                        {
                            continue;
                        }
                        if (data.ContainsKey(stock.batchnumber))//datada varmı yokmu kontrolü   
                        {
                            continue;
                        }
                        orderstockreservation loadData = new orderstockreservation
                        {
                            id = osr.id,
                            orderlineid = osr.orderlineid,
                            selectedcount = osr.selectedcount,
                            stockid = osr.stockid,
                            deleted = osr.deleted
                        };
                        data[stock.batchnumber] = loadData;
                    }
                }
                _orderLineTable.AcceptChanges();
            }
            gCOrderLineList.DataSource = _orderLineTable;
        }
        private order GetOrderFromForm()
        {
            int _orderstatusid = 0, _ordertypeid = 0, _paymentid = 0;
            decimal _ordertotalprice = 0;
            DateOnly _orderDate;
            DateOnly? _completedDate = null;
            _orderstatusid = LUEValueReader(LUEOrderStatus);
            _ordertypeid = LUEValueReader(LUEOrderType);
            _paymentid = LUEValueReader(LUEPaymentType);
            if (txtEditOrderDate.Text == null && txtEditOrderDate.Text == "")
            {
                _orderDate = DateOnly.FromDateTime(DateTime.Now);
            }
            else
            {
                DateOnly.TryParse(txtEditOrderDate.Text, out _orderDate);
            }
            if (txtCompletedDate.Text != null && txtCompletedDate.Text != "")
            {
                DateOnly.TryParse(txtCompletedDate.Text, out DateOnly parsed);
                _completedDate = parsed;
            }
            if (txtOrderTotalPrice.Text != null && txtOrderTotalPrice.Text != "")
            {
                decimal.TryParse(txtOrderTotalPrice.Text, out _ordertotalprice);
            }
            return new order
            {
                id = _selectedId,
                customerid = selectedEditCustomerId,
                ordercode = txtEditOrderCode.Text,
                orderdate = _orderDate,
                orderstatusid = _orderstatusid,
                ordertypeid = _ordertypeid,
                paymentid = _paymentid,
                completeddate = _completedDate,
                ordertotalprice = _ordertotalprice
            };
        }
        private int SelectEntity<T>(List<T> service, string title) where T : class
        {
            using (var popUpForm = new PopUpForm<T>(service, title))
            {
                if (popUpForm.ShowDialog() == DialogResult.OK)
                {
                    int secilenId = popUpForm._id;
                    return secilenId;
                }
            }
            return 0;
        }
        private void UpdateOrderTotal()
        {
            decimal total = 0;
            for (int i = 0; i <= gVOrderLineList.DataRowCount; i++)
            {
                total += Convert.ToDecimal(gVOrderLineList.GetRowCellValue(i, "itemtotalprice"));
            }
            if (gVOrderLineList.IsNewItemRow(gVOrderLineList.FocusedRowHandle))
            {
                total += Convert.ToDecimal(
                    gVOrderLineList.GetRowCellValue(gVOrderLineList.FocusedRowHandle, "itemtotalprice"));
            }
            txtOrderTotalPrice.Text = total.ToString();
        }
        private void SaveOrderLines(int orderId)
        {
            gVOrderLineList.CloseEditor();
            gVOrderLineList.UpdateCurrentRow();

            foreach (DataRow row in _orderLineTable.Rows)
            {
                bool isDeleted = row["deleted"].ToString() == "d";

                if (row.RowState == DataRowState.Added)
                {
                    if (Convert.ToInt32(row["itemid"]) == 0)
                    {
                        continue;
                    }
                    var newLine = new orderline
                    {
                        orderid = orderId,
                        itemid = Convert.ToInt32(row["itemid"]),
                        itemcount = Convert.ToInt32(row["itemcount"]),
                        itemtotalprice = Convert.ToDecimal(row["itemtotalprice"]),
                        deleted = ""
                    };
                    _orderlineService.TAdd(newLine);
                    SaveStocks(newLine.itemid, newLine.id);
                }
                else if (row.RowState == DataRowState.Modified)
                {
                    var updateLine = new orderline
                    {
                        id = Convert.ToInt32(row["id"]),
                        orderid = Convert.ToInt32(row["orderid"]),
                        itemid = Convert.ToInt32(row["itemid"]),
                        itemcount = Convert.ToInt32(row["itemcount"]),
                        itemtotalprice = Convert.ToDecimal(row["itemtotalprice"]),
                        deleted = ""
                    };

                    if (isDeleted)
                    {
                        updateLine.deleted = "d";
                    }

                    _orderlineService.TUpdate(updateLine);
                    SaveStocks(updateLine.itemid, updateLine.id);
                }
                else if (row.RowState == DataRowState.Unchanged)
                {
                    SaveStocks(Convert.ToInt32(row["itemid"]), Convert.ToInt32(row["id"]));
                }
            }
            LoadOrderLines(orderId);
        }
        private void SaveStocks(int itemId, int orderlineId)
        {
            FixChangedReservations();
            var stockReservations = _stockOnHandService.TGetAll().Where(s => s.itemid == itemId);
            foreach (var sr in stockReservations)
            {
                data.TryGetValue(sr.batchnumber, out orderstockreservation line);
                {
                    if (line == null)
                    {
                        continue;
                    }
                    int diff;
                    if (line.id > 0)
                    {
                        var oldOSR = _orderStockReservationService.TGetById(line.id);
                        diff = line.selectedcount - oldOSR.selectedcount;
                        _orderStockReservationService.TUpdate(line);
                    }
                    else
                    {
                        line.orderlineid = orderlineId;
                        diff = line.selectedcount;
                        _orderStockReservationService.TAdd(line);
                    }
                    var stock = _stockOnHandService.TGetById(line.stockid);
                    stock.itemcount -= diff;
                    _stockOnHandService.TUpdate(stock);
                }
            }
        }
        private void FixChangedReservations()
        {
            foreach (var r in _changedItemReservations)
            {
                var res = _orderStockReservationService.TGetById(r.id);
                if (res == null || res.deleted == "d")
                {
                    continue;
                }
                var stock = _stockOnHandService.TGetById(res.stockid);    
                stock.itemcount += res.selectedcount;
                _stockOnHandService.TUpdate(stock);

                res.deleted = "d";
                _orderStockReservationService.TUpdate(res);
            }
            _changedItemReservations.Clear();
        }
        private void CustomerDesicionTCorVkn(int customerId, ButtonEdit btn)
        {
            var customer = _customerService.TGetById(customerId);
            if (customerId != 0)
            {
                if (customer.tckn != null && customer.tckn != "")
                {
                    btn.EditValue = customer.tckn;
                }
                else if (customer.vkn != null && customer.vkn != "")
                {
                    btn.EditValue = customer.vkn;
                }
            }
        }
        private string GenerateRandomCode(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result;

            do
            {
                var code = new char[length];
                for (int i = 0; i < length; i++)
                {
                    code[i] = chars[RandomNumberGenerator.GetInt32(chars.Length)];
                }
                result = new string(code);
            }
            while (_orderService.TGetAll().Any(o => o.ordercode == result));

            return result;
        }
        private void CheckStock()
        {
            foreach (DataRow row in _orderLineTable.Rows)
            {
                int requiredItemCount = Convert.ToInt32(row["itemcount"]);
                int itemId = Convert.ToInt32(row["itemid"]);
                int sum = 0;


                var stocks = _stockOnHandService.TGetAll().Where(s => s.itemid == itemId);
                foreach (var stock in stocks)
                {
                    if (data.TryGetValue(stock.batchnumber, out var line))
                    {
                        sum += line.selectedcount;
                    }
                }
                if (sum != requiredItemCount)
                {
                    throw new Exception($"{row["itemcode"]} Bu ürün koduna sahip ürünün stok girişinde eksik var");
                }
            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            ListData();
            txtEditOrderCode.Text = GenerateRandomCode();
        }
        private int RowNullCheck(string columnname)
        {
            if (GVList.GetFocusedRowCellValue(columnname) != null)
            {
                return Convert.ToInt32(GVList.GetFocusedRowCellValue(columnname));
            }
            return 0;
        }

        private void repoBtnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ordertypeid = RowNullCheck("ordertypeid");
            int orderstatusid = RowNullCheck("orderstatusid");
            int paymentid = RowNullCheck("paymentid");
            int customerid = RowNullCheck("customerid");

            if (GVList.GetFocusedRowCellValue("id") != null)
            {
                _selectedId = Convert.ToInt32(GVList.GetFocusedRowCellValue("id"));
                CustomerDesicionTCorVkn(customerid, BtnEditTCKNVKN);
                txtEditOrderCode.EditValue = _orderService.TGetById(_selectedId).ordercode;
                LUEOrderType.EditValue = ordertypeid;
                LUEPaymentType.EditValue = paymentid;
                LUEOrderStatus.EditValue = orderstatusid;
                if (GVList.GetFocusedRowCellValue("orderdate") is DateOnly od)
                {
                    txtEditOrderDate.DateOnly = od;
                }

                if (GVList.GetFocusedRowCellValue("completeddate") is DateOnly cd)
                {
                    txtCompletedDate.DateOnly = cd;
                }
                else
                {
                    txtCompletedDate.EditValue = null;
                }

                txtOrderTotalPrice.EditValue = GVList.GetFocusedRowCellValue("ordertotalprice");
                LoadOrderLines(_selectedId);


            }
            xtraTabControl1.SelectedTabPage = tabDetail;
        }

        private void BtnEditTCKNVKN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            selectedEditCustomerId = SelectEntity(_customerService.TGetAll().ToList(), "Müşteri Seçim Sayfası");
            CustomerDesicionTCorVkn(selectedEditCustomerId, BtnEditTCKNVKN);
        }

        private void btnTCKNVKN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            selectedCustomerId = SelectEntity(_customerService.TGetAll().ToList(), "Müşteri Seçim Sayfası");
            CustomerDesicionTCorVkn(selectedCustomerId, btnTCKNVKN);
        }

        private void btnOrderCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            selectedOrderId = SelectEntity(_orderService.TGetAll().ToList(), "Sipariş Seçim Sayfası");
            if (selectedOrderId != 0)
            {
                btnOrderCode.EditValue = _orderService.TGetById(selectedOrderId).ordercode;
            }
        }

        private void BtnEditTCKNVKN_EditValueChanged(object sender, EventArgs e)
        {
            var value = BtnEditTCKNVKN.EditValue?.ToString();
            if (value != null)
            {
                var customer = _customerService.TGetAll().FirstOrDefault(c => c.tckn == value || c.vkn == value);
                if (customer != null)
                {
                    selectedEditCustomerId = customer.id;
                }
            }
            else
            {
                selectedCustomerId = 0;
            }
        }
        private void RemoveData(int itemId)
        {
            var batchNumbers = _stockOnHandService.TGetAll().Where(s => s.itemid == itemId).Select(s => s.batchnumber).ToList();
            foreach (var b in batchNumbers)
            {
                data.Remove(b);
            }
        }
        private void repoOrderlineDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = gVOrderLineList.GetFocusedDataRow();
            if (row == null)
            {
                return;
            }
            int id = Convert.ToInt32(row["id"]);
            int itemId = Convert.ToInt32(row["itemid"]);

            if (id > 0)
            {
                _orderlineService.TDeleteLineWithStocks(id);
                LoadOrderLines(Convert.ToInt32(row["orderid"]));
                RemoveData(itemId);
            }
            else
            {
                RemoveData(itemId);
                row.Delete();
            }
            UpdateOrderTotal();
        }

        private void btnTCKNVKN_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnOrderCode_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void LUOrderType_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void LUPaymentType_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void LUOrderStatus_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void repoBtnItemSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            List<int> itemIdinTable = new List<int>();
            foreach (DataRow row in _orderLineTable.Rows)
            {
                itemIdinTable.Add(Convert.ToInt32(row["itemid"]));
            }
            var allItem = new List<item>();
            foreach (var i in _itemService.TGetAll())
            {
                if (!itemIdinTable.Contains(i.id))//tablonun içinde item in id si varmıyı kontrol ediyor
                {
                    allItem.Add(i);
                }
            }

            var oldItemId = Convert.ToInt32(gVOrderLineList.GetFocusedRowCellValue("itemid"));
            var selectedOrderLineItemId = SelectEntity(allItem, "Ürün Seçim Sayfası");
            if (oldItemId != selectedOrderLineItemId && oldItemId != 0 && selectedOrderLineItemId != 0)
            {
                var batches = _stockOnHandService.TGetAll()
                    .Where(s => s.itemid == oldItemId)
                    .ToList();

                foreach (var b in batches)
                {
                    if (!data.TryGetValue(b.batchnumber, out var r))
                    {
                        continue;
                    }
                    if (r.id > 0)
                    {
                        _changedItemReservations.Add(r);
                    }
                    data.Remove(b.batchnumber);                                
                }
            }
            if (selectedOrderLineItemId == 0)
            {
                return;
            }

            var item = _itemService.TGetById(selectedOrderLineItemId);

            gVOrderLineList.SetRowCellValue(gVOrderLineList.FocusedRowHandle, "itemid", selectedOrderLineItemId);
            gVOrderLineList.SetRowCellValue(gVOrderLineList.FocusedRowHandle, "itemcode", item.itemcode);
            gVOrderLineList.SetRowCellValue(gVOrderLineList.FocusedRowHandle, "unitprice", item.unitprice);
        }

        private void gVOrderLineList_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gVOrderLineList.SetRowCellValue(e.RowHandle, "orderid", _selectedId);
        }
        private void UpdateOrderStock(int orderlineId)
        {
            var linestock = _orderStockReservationService.TGetAll().Where(o => o.orderlineid == orderlineId);
            foreach (var ls in linestock)
            {
                var stock = _stockOnHandService.TGetAll().FirstOrDefault(s => s.id == ls.stockid);
                if (stock != null)
                {
                    stock.itemcount += ls.selectedcount;
                }
                ls.selectedcount = 0;
            }
        }
        private void gVOrderLineList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            decimal price = Convert.ToDecimal(gVOrderLineList.GetRowCellValue(e.RowHandle, "unitprice"));
            if (e.Column.FieldName == "itemtotalprice")
            {
                UpdateOrderTotal();
            }
            if (price > 0)
            {
                if (e.Column.FieldName == "itemcount")
                {
                    int count = Convert.ToInt32(gVOrderLineList.GetRowCellValue(e.RowHandle, "itemcount"));
                    decimal newItemTotalPrice = count * price;
                    decimal oldItemTotalPrice = Convert.ToDecimal(gVOrderLineList.GetRowCellValue(e.RowHandle, "itemtotalprice"));
                    int lineId = Convert.ToInt32(gVOrderLineList.GetRowCellValue(e.RowHandle, "id"));

                    if (newItemTotalPrice != oldItemTotalPrice)
                    {
                        gVOrderLineList.SetFocusedRowCellValue("itemtotalprice", newItemTotalPrice);
                        UpdateOrderStock(lineId);
                    }
                    UpdateOrderTotal();

                }
                else if (e.Column.FieldName == "itemtotalprice")
                {
                    decimal itemtotalprice = Convert.ToDecimal(gVOrderLineList.GetRowCellValue(e.RowHandle, "itemtotalprice"));
                    int newItemCount = (int)Math.Floor(itemtotalprice / price);
                    int oldItemCount = Convert.ToInt32(gVOrderLineList.GetRowCellValue(e.RowHandle, "itemcount"));
                    int lineId = Convert.ToInt32(gVOrderLineList.GetRowCellValue(e.RowHandle, "id"));

                    if (newItemCount != oldItemCount)
                    {
                        gVOrderLineList.SetFocusedRowCellValue("itemcount", newItemCount);
                        UpdateOrderStock(lineId);
                    }
                    UpdateOrderTotal();
                }
            }
        }

        private void gVOrderLineList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                BeginInvoke(new Action(() => gVOrderLineList.AddNewRow()));
            }
        }

        private void LUEOrderStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LUEOrderStatus.EditValue) == 2)
            {
                txtCompletedDate.EditValue = DateOnly.FromDateTime(DateTime.Now);
            }
        }

        private void repoBtnStockEntry_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var sp = Program.serviceProvider;
            var itemId = Convert.ToInt32(gVOrderLineList.GetFocusedRowCellValue("itemid"));
            if (itemId != 0)
            {
                int orderlineId = 0, requredItemCount = 0;
                if (gVOrderLineList.GetFocusedRowCellValue("id") != null)
                {
                    orderlineId = Convert.ToInt32(gVOrderLineList.GetFocusedRowCellValue("id"));
                }
                if (gVOrderLineList.GetFocusedRowCellValue("itemcount") != null)
                {
                    requredItemCount = Convert.ToInt32(gVOrderLineList.GetFocusedRowCellValue("itemcount"));
                }
                var reservationService = sp.GetRequiredService<IOrderStockReservationService>();
                var stockService = sp.GetRequiredService<IStockOnHandService>();

                var orderStockForm = new OrderStockForm(data, itemId, orderlineId, requredItemCount, reservationService, stockService, _orderlineService, _itemService);
                orderStockForm.Show();
            }
        }
    }
}
