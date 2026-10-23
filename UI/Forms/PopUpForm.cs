using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class PopUpForm<T> : Form where T : class
    {
        //popupformu bir değer alıcak örneğin sayfa bu sayfa neyse ona göre switch case yazdırılacak
        //geri dönüşde o satıra çift tıkladığımızda showdialogla gönderilsin
        public int _id { get; private set; }
        public PopUpForm(List<T> data, string title)
        {
            InitializeComponent();
            this.Text = title;
            gCList.DataSource = data;
        }

        private void gVList_DoubleClick(object sender, EventArgs e)
        {
            object id = gVList.GetFocusedRowCellValue("id");
            if (id != null && int.TryParse(id.ToString(), out int result))
            {
                this._id = result;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
        }
    }
}
