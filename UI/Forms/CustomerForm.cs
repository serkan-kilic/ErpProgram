using Business.Abstract;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
using Entities.concrete;
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
    public partial class CustomerForm : BaseForm
    {
        private readonly ICustomerTypeService _customerTypeService;
        private readonly IProvinceService _provinceService;
        private readonly IDistrictService _districtService;
        private readonly ICustomerService _customerService;
        private int selectedTCKNId, selectedVKNId;
        public CustomerForm(ICustomerTypeService customerTypeService, IProvinceService provinceService, IDistrictService districtService, ICustomerService customerService)
        {
            _customerTypeService = customerTypeService;
            _provinceService = provinceService;
            _districtService = districtService;
            _customerService = customerService;
            formName = "Müşteri Yönetim";
            formImg = "business%20objects/bo_employee";
            InitializeComponent();
        }
        protected void FindDistrict(LookUpEdit lueProvince, LookUpEdit lueDistrict)
        {
            if (lueProvince.EditValue != null)
            {
                int selectedProvinceid = Convert.ToInt32(lueProvince.EditValue);
                lueDistrict.Enabled = true;
                lueDistrict.Properties.DataSource = _districtService.TGetAll().Where(x => x.provinceid == selectedProvinceid);
            }
        }
        
        private customer GetCustomerFromForm()
        {
            int _districtid = 0, _customertypeid = 0;
            if (LUEDistrict.EditValue != null)
            {
                _districtid = Convert.ToInt32(LUEDistrict.EditValue);
            }
            if (LUECustomerType.EditValue != null)
            {
                _customertypeid = Convert.ToInt32(LUECustomerType.EditValue);
            }
            var customer = new customer
            {
                id = _selectedId,
                districtid = _districtid,
                customertypeid = _customertypeid,
                phonenumber = txtEditPhoneNumber.Text,
                email = txtEditEmail.Text,
                address = txtEditAddress.Text,
                currency = txtEditCurrency.Text,
            };
            if (_customertypeid == 2)
            {
                customer.name = txtEditName.Text;
                customer.tckn = txtEditTCKN.Text;
                customer.surname = txtEditSurname.Text;

            }
            else if (_customertypeid == 3)
            {
                customer.title = txtEditTitle.Text;
                customer.vkn = txtEditVKN.Text;
                customer.taxoffice = txtEditTaxOffice.Text;
            }
            return customer;
        }

        protected override void SaveData()
        {
            try
            {
                var saveData = GetCustomerFromForm();
                _customerService.TAdd(saveData);
                MessageBox.Show("Müşteri başarılı bir şekilde eklendi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void ListData()
        {
            var districtService = _districtService.TGetAll();
            var provinceService = _provinceService.TGetAll();
            var customerTypeService = _customerTypeService.TGetAll();

            LUCustomerType.Properties.DataSource = customerTypeService;
            LUCustomerType.EditValue = 1;
            LUProvince.Properties.DataSource = provinceService;
            LUECustomerType.Properties.DataSource = customerTypeService.Where(x => x.id != 1);
            LUECustomerType.EditValue = 2;
            LUEProvince.Properties.DataSource = provinceService;

            FindDistrict(LUEProvince, LUEDistrict);
            FindDistrict(LUProvince, LUDistrict);

            repoLUDistrict.DataSource = districtService;
            repoLUCustomerType.DataSource = customerTypeService;
            repoLUProvince.DataSource = provinceService;

            GCList.DataSource = _customerService.TGetCustomerWithDistrict();
        }
        protected override void UpdateData()
        {
            try
            {
                var updateData = GetCustomerFromForm();
                _customerService.TUpdate(updateData);
                MessageBox.Show("Müşteri başarılı bir şekilde güncellendi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (FluentValidation.ValidationException ex)
            {
                MessageBox.Show(ex.Errors.First().ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void DeleteData()
        {
            var deleteData = GetCustomerFromForm().id;
            if (deleteData > 0)
            {
                _customerService.TDeleteCustomerWithOrderAndLines(deleteData);
                MessageBox.Show("Müşteri başarılı bir şekilde silindi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silmek için bir müşteri seçmelisiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LUCustomerType.EditValue = 1;
            LUECustomerType.EditValue = 2;

            selectedTCKNId = 0;
            selectedVKNId = 0;

            LUProvince.Clear();
            LUDistrict.Clear();
            LUDistrict.Enabled = false;
            LUEDistrict.Clear();
            LUEDistrict.Enabled = false;
            LUEProvince.Clear();
            txtCurrency.Clear();
            txtEditAddress.Clear();
            txtEditCurrency.Clear();
            txtEditEmail.Clear();
            txtEditName.Clear();
            txtEditPhoneNumber.Clear();
            txtEditSurname.Clear();
            txtEditTaxOffice.Clear();
            txtEditTCKN.Clear();
            txtEditTitle.Clear();
            txtEditVKN.Clear();

            btnTCKN.Clear();
            btnVKN.Clear();
            ListData();
        }
        protected override void FilterData()
        {
            var query = _customerService.TGetQueryable();

            if (LUCustomerType.EditValue != null && Convert.ToInt32(LUCustomerType.EditValue) > 0)
            {
                var customertypeid = Convert.ToInt32(LUCustomerType.EditValue);
                if (customertypeid == 1)
                {
                    SetFilterCustomerTypeVisibility(true, true);
                }
                else if (customertypeid == 2)
                {
                    SetFilterCustomerTypeVisibility(true, false);
                    query = query.Where(x => x.customertypeid == customertypeid);
                }
                else if (customertypeid == 3)
                {
                    SetCustomerTypeVisibility(false, true);
                    query = query.Where(x => x.customertypeid == customertypeid);
                }
            }
            if (LUProvince.EditValue != null && Convert.ToInt32(LUProvince.EditValue) > 0)
            {
                var provinceid = Convert.ToInt32(LUProvince.EditValue);
                query = query.Where(x => x.District != null && x.District.provinceid == provinceid);
            }
            if (LUDistrict.EditValue != null && Convert.ToInt32(LUDistrict.EditValue) > 0)
            {
                var districtid = Convert.ToInt32(LUDistrict.EditValue);
                query = query.Where(x => x.districtid == districtid);
            }
            if (txtCurrency.EditValue != null && txtCurrency.Text.Trim() != "")
            {
                var currency = txtCurrency.Text;
                query = query.Where(x => x.currency != null && x.currency.StartsWith(currency));
            }
            if (btnTCKN.EditValue != null && btnTCKN.Text.Trim() != "")
            {
                var tckn = btnTCKN.Text;
                query = query.Where(x => x.tckn != null && x.tckn.StartsWith(tckn));
            }
            if (btnVKN.EditValue != null && btnVKN.Text.Trim() != "")
            {
                var vkn = btnVKN.Text;
                query = query.Where(x => x.vkn != null && x.vkn.StartsWith(vkn));
            }

            GCList.DataSource = query.ToList();
        }
        private void ClearCustomerTypeFields()
        {
            txtEditName.Clear();
            txtEditSurname.Clear();
            txtEditTCKN.Clear();
            txtEditTaxOffice.Clear();
            txtEditVKN.Clear();
            txtEditTitle.Clear();
        }
        private void SetEditCustomerTypeVisibility(bool person, bool company)
        {
            lblEditName.Visible = person;
            lblEditSurname.Visible = person;
            lblEditTCKN.Visible = person;
            txtEditName.Visible = person;
            txtEditSurname.Visible = person;
            txtEditTCKN.Visible = person;

            lblEditTitle.Visible = company;
            lblEditTaxOffice.Visible = company;
            lblEditVKN.Visible = company;
            txtEditTitle.Visible = company;
            txtEditTaxOffice.Visible = company;
            txtEditVKN.Visible = company;
        }
        private void SetCustomerTypeVisibility(bool person, bool company)
        {
            lblTCKN.Visible = person;
            btnTCKN.Visible = person;

            lblVKN.Visible = company;
            btnVKN.Visible = company;

            SetFilterCustomerTypeVisibility(person, company);
        }
        private void SetFilterCustomerTypeVisibility(bool person, bool company)
        {
            gCTCKN.Visible = person;
            gCCustomerName.Visible = person;
            gCCustomerSurname.Visible = person;

            gCVKN.Visible = company;
            gCTaxOffice.Visible = company;
            gCTitle.Visible = company;
        }
        private int SelectCustomer()
        {
            using (var popUpForm = new PopUpForm<customer>(_customerService.TGetAll().ToList(), "Ürün Seçim"))
            {
                if (popUpForm.ShowDialog() == DialogResult.OK)
                {
                    int secilenId = popUpForm._id;
                    return secilenId;
                }
            }
            return 0;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void LUProvince_EditValueChanged(object sender, EventArgs e)
        {
            FindDistrict(LUProvince, LUDistrict);
            FilterData();
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
            int _customertypeid = RowNullCheck("customertypeid");
            int _districtid = RowNullCheck("districtid");
            int _provinceid = RowNullCheck("District.provinceid");


            if (GVList.GetFocusedRowCellValue("id") != null)
            {
                _selectedId = Convert.ToInt32(GVList.GetFocusedRowCellValue("id"));
                LUECustomerType.EditValue = _customertypeid;
                LUEDistrict.EditValue = _districtid;
                LUEProvince.EditValue = _provinceid;
                txtEditAddress.EditValue = GVList.GetFocusedRowCellValue("address");
                txtEditPhoneNumber.EditValue = GVList.GetFocusedRowCellValue("phonenumber");
                txtEditEmail.EditValue = GVList.GetFocusedRowCellValue("email");
                txtEditCurrency.EditValue = GVList.GetFocusedRowCellValue("currency");

                if (_customertypeid == 2)
                {
                    txtEditName.EditValue = GVList.GetFocusedRowCellValue("name");
                    txtEditSurname.EditValue = GVList.GetFocusedRowCellValue("surname");
                    txtEditTCKN.EditValue = GVList.GetFocusedRowCellValue("tckn");
                }
                else if (_customertypeid == 3)
                {
                    txtEditTitle.EditValue = GVList.GetFocusedRowCellValue("title");
                    txtEditTaxOffice.EditValue = GVList.GetFocusedRowCellValue("taxoffice");
                    txtEditVKN.EditValue = GVList.GetFocusedRowCellValue("vkn");
                }

                xtraTabControl1.SelectedTabPage = tabDetail;
            }
        }

        private void LUEProvince_EditValueChanged(object sender, EventArgs e)
        {
            FindDistrict(LUEProvince, LUEDistrict);
        }

        private void LUECustomerType_EditValueChanged(object sender, EventArgs e)
        {
            ClearCustomerTypeFields();
            int _customertypeid = 0;
            if (LUECustomerType.EditValue != null)
            {
                _customertypeid = Convert.ToInt32(LUECustomerType.EditValue);
            }
            if (_customertypeid == 2)
            {
                //bireysel
                SetEditCustomerTypeVisibility(true, false);
            }
            else if (_customertypeid == 3)
            {
                //kurumsal
                SetEditCustomerTypeVisibility(false, true);
            }
            else
            {
                SetEditCustomerTypeVisibility(false, false);
            }
        }

        private void LUCustomerType_EditValueChanged(object sender, EventArgs e)
        {
            //label vergi kimlik no - lokasyon : 304; 80
            //buton vergi kimlik no - lokasyon : 408; 77
            //label tckn - lokasyon : 24; 72
            //buton tckn - lokasyon : 119; 69
            int _customertypeid = 0;
            if (LUCustomerType.EditValue != null)
            {
                _customertypeid = Convert.ToInt32(LUCustomerType.EditValue);
            }
            if (_customertypeid == 1)
            {
                SetCustomerTypeVisibility(true, true);
                lblVKN.Location = new Point(304, 80);
                btnVKN.Location = new Point(408, 77);
            }
            else if (_customertypeid == 2)
            {
                SetCustomerTypeVisibility(true, false);
            }
            else if (_customertypeid == 3)
            {
                SetCustomerTypeVisibility(false, true);
                lblVKN.Location = new Point(24, 80);
                btnVKN.Location = new Point(119, 77);
            }
            FilterData();
        }

        private void LUDistrict_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtCurrency_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnTCKN_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnVKN_EditValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnTCKN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            selectedTCKNId = SelectCustomer();
            if (selectedTCKNId > 0)
            {
                customer entity = _customerService.TGetById(selectedTCKNId);
                btnTCKN.EditValue = entity.tckn;
            }
        }

        private void btnVKN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           selectedVKNId = SelectCustomer();
            if (selectedVKNId > 0)
            {
                customer entity = _customerService.TGetById(selectedVKNId);
                btnVKN.EditValue = entity.vkn;
            }
        }
    }
}
