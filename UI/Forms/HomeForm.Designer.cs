namespace UI
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnOrderSale = new DevExpress.XtraEditors.SimpleButton();
            btnItem = new DevExpress.XtraEditors.SimpleButton();
            btnStock = new DevExpress.XtraEditors.SimpleButton();
            btnCustomer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(btnOrderSale);
            panelControl1.Controls.Add(btnItem);
            panelControl1.Controls.Add(btnStock);
            panelControl1.Controls.Add(btnCustomer);
            panelControl1.Location = new Point(13, 14);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(438, 179);
            panelControl1.TabIndex = 0;
            // 
            // btnOrderSale
            // 
            btnOrderSale.ImageOptions.ImageUri.Uri = "edit/paste";
            btnOrderSale.Location = new Point(20, 106);
            btnOrderSale.Name = "btnOrderSale";
            btnOrderSale.Size = new Size(182, 56);
            btnOrderSale.TabIndex = 3;
            btnOrderSale.Text = "Sipariş Satış Yönetimi";
            btnOrderSale.Click += btnOrderSale_Click;
            // 
            // btnItem
            // 
            btnItem.ImageOptions.ImageUri.Uri = "Edit";
            btnItem.Location = new Point(238, 106);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(182, 56);
            btnItem.TabIndex = 2;
            btnItem.Text = "Ürün Yönetimi";
            btnItem.Click += btnItem_Click;
            // 
            // btnStock
            // 
            btnStock.ImageOptions.ImageUri.Uri = "business%20objects/bo_order";
            btnStock.Location = new Point(238, 17);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(182, 56);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stok Takip";
            btnStock.Click += btnStock_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.ImageOptions.ImageUri.Uri = "business%20objects/bo_employee";
            btnCustomer.Location = new Point(20, 17);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(182, 56);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Müşteri Yönetimi";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 210);
            Controls.Add(panelControl1);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCustomer;
        private DevExpress.XtraEditors.SimpleButton btnOrderSale;
        private DevExpress.XtraEditors.SimpleButton btnItem;
        private DevExpress.XtraEditors.SimpleButton btnStock;
    }
}