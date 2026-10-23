using Business.Abstract;
using DevExpress.DocumentView.Controls;
using Entities.concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI.Forms;

namespace UI
{
    public partial class StockForm : BaseForm
    {
        private readonly IStockOnHandService _stockOnHandService;
        private readonly IItemService _itemService;
        private int selectedItemId, selectedEditItemId;

        public StockForm(IStockOnHandService stockOnHandService, IItemService itemService)
        {
            formName = "Stok Yönetim";
            formImg = "business%20objects/bo_order";
            _stockOnHandService = stockOnHandService;
            _itemService = itemService;
            InitializeComponent();
        }
        //stok ekleme çıkartma işlemi yapılabilir

        private int SelectItem()
        {
            using (var popUpForm = new PopUpForm<item>(_itemService.TGetAll().ToList(), "Ürün Seçim"))
            {
                if (popUpForm.ShowDialog() == DialogResult.OK)
                {
                    int secilenId = popUpForm._id;
                    return secilenId;
                }
            }
            return 0;
        }
        private stockonhand GetStockFromForm()
        {
            int _itemcount = 0;
            if (txtEditItemCount.Text != null)
            {
                int.TryParse(txtEditItemCount.Text, out _itemcount);
            }
            return new stockonhand
            {
                id = _selectedId,
                itemid = selectedEditItemId,
                batchnumber = txtEditBatchNumber.Text,
                itemcount = _itemcount
            };
        }
        protected override void SaveData()
        {
            try
            {
                stockonhand saveStock = GetStockFromForm();
                _stockOnHandService.TAdd(saveStock);
                MessageBox.Show("Stok başarılı bir şekilde eklendi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void ListData()
        {
            GCList.DataSource = _stockOnHandService.TGetAll();
            repoLUItem.DataSource = _itemService.TGetAll();
        }
        protected override void UpdateData()
        {
            try
            {
                stockonhand updateStock = GetStockFromForm();
                _stockOnHandService.TUpdate(updateStock);
                MessageBox.Show("Stok başarılı bir şekilde güncellendi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void DeleteData()
        {
            var deleteData = GetStockFromForm().id;
            if (deleteData > 0)
            {
                _stockOnHandService.TDeleteStockWithOrderStockReservation(deleteData);
                MessageBox.Show("Stok başarılı bir şekilde silindi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silmek için bir stok seçmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void CloseWindow()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
        protected override void ClearData()
        {
            _selectedId = 0;
            selectedEditItemId = 0;
            selectedItemId = 0;
            txtEditItemCount.Clear();
            txtItemMinCount.Clear();
            txtEditBatchNumber.Clear();
            btnItemCode.Clear();
            btnEditItemCode.Clear();
            btnEditItemCode.Properties.Buttons[0].Caption = "";
        }
        protected override void FilterData()
        {
            var query = _stockOnHandService.TGetQueryable();

            if (btnItemCode.EditValue != null) //ürün kodunu geri sildiğimizde id den kontrol ettiğimiz için elimizle yazmamız bişey ifade etmiyordu
            {//buraya bak
                var itemcode = btnItemCode.Text.Trim();
                var matchingItem = _itemService.TGetAll().Where(x => x.itemcode.StartsWith(itemcode)).Select(x => x.id).ToList();
                query = query.Where(x => matchingItem.Contains(x.itemid));
            }

            //if (selectedItemId > 0)
            //{
            //    query = query.Where(x => x.itemid == selectedItemId);
            //}

            if (txtItemMinCount.Text != null && int.TryParse(txtItemMinCount.Text,out int minCount)&& minCount > 0)
            {
                int itemcount = Convert.ToInt32(txtItemMinCount.Text);
                query = query.Where(x => x.itemcount >= itemcount);
            }
            if (txtItemMaxCount.Text != null && int.TryParse(txtItemMaxCount.Text,out int maxCount) && maxCount> 0)
            {
                query = query.Where(x => x.itemcount <= maxCount);
            }

            GCList.DataSource = query.ToList();
        }
        private void StockForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void btnEditItemName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            selectedEditItemId = SelectItem();
            if (selectedEditItemId > 0)
            {
                btnEditItemCode.Properties.Buttons[0].Caption = _itemService.TGetById(selectedEditItemId).itemcode;
            }
        }

        private void btnItemCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            selectedItemId = SelectItem();
            if (selectedItemId > 0)
            {
                btnItemCode.Text = _itemService.TGetById(selectedItemId).itemcode;
            }
        }

        private void repoBtnItemEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GVList.GetFocusedRowCellValue("id") != null)
            {
                _selectedId = Convert.ToInt32(GVList.GetFocusedRowCellValue("id"));
                selectedEditItemId = Convert.ToInt32(GVList.GetFocusedRowCellValue("itemid"));
                btnEditItemCode.Properties.Buttons[0].Caption = _itemService.TGetById(selectedEditItemId).itemcode;
                txtEditItemCount.Text = GVList.GetFocusedRowCellValue("itemcount").ToString();
                txtEditBatchNumber.Text = GVList.GetFocusedRowCellValue("batchnumber").ToString();

                xtraTabControl1.SelectedTabPage = tabDetail;
            }
        }

        private void btnItemCode_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtItemMinCount_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtItemMaxCount_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
