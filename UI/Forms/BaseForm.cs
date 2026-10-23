using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        //metot tanımları
        protected virtual void SaveData() { }
        protected virtual void UpdateData() { }
        protected virtual void DeleteData() { } //transection ile herşey silinicek
        protected virtual void ListData() { }
        protected virtual void ClearData() { }
        protected virtual void FilterData() { }
        protected virtual void CloseWindow() { }

        //değişken tanımları
        protected int _selectedId;
        protected string formName;
        protected string formImg;

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                UpdateData();
                ListData();
            }
            else
            {
                SaveData();
                ListData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            ClearData();
            ListData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            lblPageName.Text = formName;
            lblPageName.ImageOptions.ImageUri = formImg;
        }
    }
}
