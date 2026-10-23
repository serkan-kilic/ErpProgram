using Business.Abstract;
using DataAccess.Context;
using DevExpress.XtraRichEdit.Commands;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UI;
using UI.Forms;

namespace UI
{
    public partial class ItemManagementForm : BaseForm
    {
        //save ile update aynı tuş ile yönetilecek
        //eğer seçip güncellemekten vazgeçerse diye yeni bir buton olucak
        //min 2 adet üründen filtreleme yapmamız gerek 
        //gv da detayı çekmek için buton olucak 
        //foreign key olan satırlarda lookupedit kullanılacak
        private readonly IItemService _itemService;
        private readonly ICategoryService _categoryServices;
        private int selectedItemId;//filtre için oluşturuldu

        public ItemManagementForm(ICategoryService categoryServices, IItemService itemService)
        {
            _categoryServices = categoryServices;
            _itemService = itemService;
            formName = "Ürün Yönetim";
            formImg = "Edit";
            InitializeComponent();
        }
        private item GetItemFromForm()
        {
            decimal _unitprice = 0;
            if (txtEditItemUnitPrice.EditValue != null)
            {
                decimal.TryParse(txtEditItemUnitPrice.EditValue.ToString(), out _unitprice);
            }
            return new item
            {
                id = _selectedId,
                categoryid = Convert.ToInt32(LUECategories.EditValue),
                itemcode = txtEditItemCode.Text,
                name = txtEditItemName.Text,
                unitprice = _unitprice
            };
        }
        
        protected override void SaveData()
        {
            try
            {
                item itemSave = GetItemFromForm();
                _itemService.TAdd(itemSave);
                MessageBox.Show("Ürün başarılı bir şekilde eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void ListData()
        {
            LUCategories.EditValue = 1;
            LUCategories.Properties.DataSource = _categoryServices.TGetAll();
            LUECategories.Properties.DataSource = _categoryServices.TGetAll().Where(x => x.id != 1);

            GCList.DataSource = _itemService.TGetAll();
            repoLUItem.DataSource = _categoryServices.TGetAll();
        }
        protected override void UpdateData()
        {
            try
            {
                item itemUpdate = GetItemFromForm();
                _itemService.TUpdate(itemUpdate);
                MessageBox.Show("Ürün başarılı bir şekilde güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        protected override void DeleteData()
        {
            var itemDelete = GetItemFromForm().id;
            if (itemDelete > 0)
            {
                _itemService.TDeleteItemWithLineAndStock(itemDelete);
                MessageBox.Show("Ürün başarılı bir şekilde silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silmek için bir ürün seçmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LUCategories.EditValue = 1;
            LUECategories.EditValue = null;
            txtItemName.Clear();
            btnItemCode.Clear();
            txtItemMinUnitPrice.Clear();
            txtItemMaxUnitPrice.Clear();
            txtEditItemCode.Clear();
            txtEditItemName.Clear();
            txtEditItemUnitPrice.Clear();
        }
        protected override void FilterData()
        {
            var query = _itemService.TGetQueryable();

            if (LUCategories.EditValue != null && Convert.ToInt32(LUCategories.EditValue) > 1)
            {
                int categoryId = Convert.ToInt32(LUCategories.EditValue);
                query = query.Where(x => x.categoryid == categoryId);
            }
            if (btnItemCode.EditValue != null && btnItemCode.Text.Trim() != "")
            {
                string itemcode = btnItemCode.Text.Trim().ToLower();
                query = query.Where(x => x.itemcode.ToLower().Contains(itemcode));
            }
            if (txtItemMinUnitPrice.EditValue != null && decimal.TryParse(txtItemMinUnitPrice.Text,out decimal minUnitPrice)&&minUnitPrice>0)
            {
                query = query.Where(x => x.unitprice >= minUnitPrice);
            }
            if (txtItemMaxUnitPrice.EditValue != null && decimal.TryParse(txtItemMaxUnitPrice.Text,out decimal maxUnitPrice) && maxUnitPrice>0)
            {
                query = query.Where(x => x.unitprice <= maxUnitPrice);
            }

            GCList.DataSource = query.ToList();
        }
        private void ItemManagementForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void repoBtnItemEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GVList.GetFocusedRowCellValue("id") != null)
            {
                _selectedId = Convert.ToInt32(GVList.GetFocusedRowCellValue("id"));
                LUECategories.EditValue = GVList.GetFocusedRowCellValue("categoryid");
                txtEditItemCode.EditValue = GVList.GetFocusedRowCellValue("itemcode");
                txtEditItemName.EditValue = GVList.GetFocusedRowCellValue("name");
                txtEditItemUnitPrice.EditValue = GVList.GetFocusedRowCellValue("unitprice");

                xtraTabControl1.SelectedTabPage = tabDetail;
            }
        }

        private void btnItemCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (var popUpForm = new PopUpForm<item>(_itemService.TGetAll().ToList(), "Ürün Seçim"))
            {
                if (popUpForm.ShowDialog() == DialogResult.OK)
                {
                    selectedItemId = popUpForm._id;
                }
            }
            if (selectedItemId > 0)
            {
                item entity = _itemService.TGetById(selectedItemId);
                btnItemCode.EditValue = entity.itemcode;
                txtItemName.EditValue = entity.name;
            }
        }

        private void LUCategories_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnItemCode_EditValueChanged(object sender, EventArgs e)
        {
            var itemcode = btnItemCode.Text.Trim();
            var foundItem = _itemService.TGetQueryable().FirstOrDefault(x => x.itemcode == itemcode);
            if (foundItem != null)
            {
                txtItemName.Text = foundItem.name;
            }
            else
            {
                txtItemName.Clear();
            }
            FilterData();
        }

        private void txtItemMinUnitPrice_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtItemMaxUnitPrice_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
