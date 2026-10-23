using Microsoft.Extensions.DependencyInjection;
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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private void formOpen(Form form)
        {
            form.Show();
            this.Close();
        }
        private void btnItem_Click(object sender, EventArgs e)
        {
            formOpen(Program.serviceProvider.GetRequiredService<ItemManagementForm>());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            formOpen(Program.serviceProvider.GetRequiredService<CustomerForm>());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            formOpen(Program.serviceProvider.GetRequiredService<StockForm>());
        }

        private void btnOrderSale_Click(object sender, EventArgs e)
        {
            formOpen(Program.serviceProvider.GetRequiredService<OrderForm>());
        }
    }
}
