namespace UI.Forms
{
    partial class OrderStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStockForm));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            GCList = new DevExpress.XtraGrid.GridControl();
            GVList = new DevExpress.XtraGrid.Views.Grid.GridView();
            gCId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCOrderLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCStockId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCBatchNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            gCStockItemCount = new DevExpress.XtraGrid.Columns.GridColumn();
            gCSeletedCount = new DevExpress.XtraGrid.Columns.GridColumn();
            gCRemainingStockCount = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            BtnDecline = new DevExpress.XtraEditors.SimpleButton();
            btnAccept = new DevExpress.XtraEditors.SimpleButton();
            txtRequiredItemCount = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            txtItemCode = new DevExpress.XtraEditors.TextEdit();
            txtItemName = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GCList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GVList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtRequiredItemCount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(textEdit3);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(textEdit2);
            panelControl1.Controls.Add(textEdit1);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(2, 23);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(950, 150);
            panelControl1.TabIndex = 0;
            // 
            // textEdit3
            // 
            textEdit3.Enabled = false;
            textEdit3.Location = new Point(702, 26);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Size = new Size(160, 22);
            textEdit3.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(608, 29);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(71, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Sipariş Kodu";
            // 
            // textEdit2
            // 
            textEdit2.Enabled = false;
            textEdit2.Location = new Point(406, 26);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Size = new Size(160, 22);
            textEdit2.TabIndex = 3;
            // 
            // textEdit1
            // 
            textEdit1.Enabled = false;
            textEdit1.Location = new Point(118, 28);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Size = new Size(160, 22);
            textEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(312, 29);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(59, 16);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Ürün Kodu";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(24, 29);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(49, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Ürün Adı";
            // 
            // groupControl1
            // 
            groupControl1.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl1.CaptionImageOptions.Image");
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(panelControl2);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1218, 574);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "Bilgi";
            // 
            // groupControl2
            // 
            groupControl2.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl2.CaptionImageOptions.Image");
            groupControl2.Controls.Add(GCList);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 123);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(1214, 449);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Liste";
            // 
            // GCList
            // 
            GCList.Dock = DockStyle.Fill;
            GCList.Location = new Point(2, 23);
            GCList.MainView = GVList;
            GCList.Name = "GCList";
            GCList.Size = new Size(1210, 424);
            GCList.TabIndex = 0;
            GCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { GVList });
            // 
            // GVList
            // 
            GVList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gCId, gCOrderLineId, gCStockId, gCBatchNumber, gCStockItemCount, gCSeletedCount, gCRemainingStockCount });
            GVList.GridControl = GCList;
            GVList.Name = "GVList";
            GVList.OptionsView.ShowGroupPanel = false;
            GVList.CellValueChanged += GVList_CellValueChanged;
            // 
            // gCId
            // 
            gCId.Caption = "Id";
            gCId.FieldName = "id";
            gCId.Name = "gCId";
            gCId.OptionsColumn.AllowEdit = false;
            // 
            // gCOrderLineId
            // 
            gCOrderLineId.Caption = "OrderLineId";
            gCOrderLineId.FieldName = "orderlineid";
            gCOrderLineId.Name = "gCOrderLineId";
            gCOrderLineId.OptionsColumn.AllowEdit = false;
            // 
            // gCStockId
            // 
            gCStockId.Caption = "StockId";
            gCStockId.FieldName = "stockid";
            gCStockId.Name = "gCStockId";
            // 
            // gCBatchNumber
            // 
            gCBatchNumber.AppearanceCell.Options.UseTextOptions = true;
            gCBatchNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCBatchNumber.Caption = "Parti Numarası";
            gCBatchNumber.FieldName = "batchnumber";
            gCBatchNumber.Name = "gCBatchNumber";
            gCBatchNumber.OptionsColumn.AllowEdit = false;
            gCBatchNumber.Visible = true;
            gCBatchNumber.VisibleIndex = 0;
            gCBatchNumber.Width = 1000;
            // 
            // gCStockItemCount
            // 
            gCStockItemCount.AppearanceCell.Options.UseTextOptions = true;
            gCStockItemCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCStockItemCount.Caption = "Stoktaki Ürün Sayısı";
            gCStockItemCount.FieldName = "itemcount";
            gCStockItemCount.Name = "gCStockItemCount";
            gCStockItemCount.OptionsColumn.AllowEdit = false;
            gCStockItemCount.Visible = true;
            gCStockItemCount.VisibleIndex = 1;
            gCStockItemCount.Width = 1000;
            // 
            // gCSeletedCount
            // 
            gCSeletedCount.AppearanceCell.Options.UseTextOptions = true;
            gCSeletedCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCSeletedCount.Caption = "Siparişe Ayrılan Ürün Sayısı";
            gCSeletedCount.FieldName = "selectedcount";
            gCSeletedCount.Name = "gCSeletedCount";
            gCSeletedCount.Visible = true;
            gCSeletedCount.VisibleIndex = 2;
            gCSeletedCount.Width = 1000;
            // 
            // gCRemainingStockCount
            // 
            gCRemainingStockCount.AppearanceCell.Options.UseTextOptions = true;
            gCRemainingStockCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCRemainingStockCount.Caption = "Kalan Stok Sayısı";
            gCRemainingStockCount.FieldName = "remainingstockcount";
            gCRemainingStockCount.Name = "gCRemainingStockCount";
            gCRemainingStockCount.OptionsColumn.AllowEdit = false;
            gCRemainingStockCount.UnboundDataType = typeof(int);
            gCRemainingStockCount.Visible = true;
            gCRemainingStockCount.VisibleIndex = 3;
            gCRemainingStockCount.Width = 1000;
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.Controls.Add(BtnDecline);
            panelControl2.Controls.Add(btnAccept);
            panelControl2.Controls.Add(txtRequiredItemCount);
            panelControl2.Controls.Add(labelControl7);
            panelControl2.Controls.Add(txtItemCode);
            panelControl2.Controls.Add(txtItemName);
            panelControl2.Controls.Add(labelControl5);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 23);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1214, 100);
            panelControl2.TabIndex = 0;
            // 
            // BtnDecline
            // 
            BtnDecline.Appearance.BackColor = Color.Gray;
            BtnDecline.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
            BtnDecline.Appearance.ForeColor = Color.Transparent;
            BtnDecline.Appearance.Options.UseBackColor = true;
            BtnDecline.Appearance.Options.UseBorderColor = true;
            BtnDecline.Appearance.Options.UseForeColor = true;
            BtnDecline.AppearanceHovered.BackColor = Color.Gray;
            BtnDecline.AppearanceHovered.BorderColor = Color.Gray;
            BtnDecline.AppearanceHovered.Options.UseBackColor = true;
            BtnDecline.AppearanceHovered.Options.UseBorderColor = true;
            BtnDecline.ImageOptions.Image = (Image)resources.GetObject("BtnDecline.ImageOptions.Image");
            BtnDecline.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            BtnDecline.Location = new Point(1034, 30);
            BtnDecline.Name = "BtnDecline";
            BtnDecline.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            BtnDecline.Size = new Size(43, 42);
            BtnDecline.TabIndex = 9;
            BtnDecline.Click += BtnDecline_Click;
            // 
            // btnAccept
            // 
            btnAccept.Appearance.BackColor = Color.Gray;
            btnAccept.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAccept.Appearance.ForeColor = Color.Transparent;
            btnAccept.Appearance.Options.UseBackColor = true;
            btnAccept.Appearance.Options.UseBorderColor = true;
            btnAccept.Appearance.Options.UseForeColor = true;
            btnAccept.AppearanceHovered.BackColor = Color.Gray;
            btnAccept.AppearanceHovered.BorderColor = Color.Gray;
            btnAccept.AppearanceHovered.Options.UseBackColor = true;
            btnAccept.AppearanceHovered.Options.UseBorderColor = true;
            btnAccept.ImageOptions.Image = (Image)resources.GetObject("btnAccept.ImageOptions.Image");
            btnAccept.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnAccept.Location = new Point(968, 30);
            btnAccept.Name = "btnAccept";
            btnAccept.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnAccept.Size = new Size(43, 42);
            btnAccept.TabIndex = 8;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtRequiredItemCount
            // 
            txtRequiredItemCount.Enabled = false;
            txtRequiredItemCount.Location = new Point(772, 39);
            txtRequiredItemCount.Name = "txtRequiredItemCount";
            txtRequiredItemCount.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtRequiredItemCount.Properties.Appearance.Options.UseFont = true;
            txtRequiredItemCount.Size = new Size(160, 22);
            txtRequiredItemCount.TabIndex = 7;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(630, 42);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(115, 16);
            labelControl7.TabIndex = 6;
            labelControl7.Text = "Gereken Ürün Sayısı";
            // 
            // txtItemCode
            // 
            txtItemCode.Enabled = false;
            txtItemCode.Location = new Point(412, 39);
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemCode.Properties.Appearance.Options.UseFont = true;
            txtItemCode.Size = new Size(160, 22);
            txtItemCode.TabIndex = 4;
            // 
            // txtItemName
            // 
            txtItemName.Enabled = false;
            txtItemName.Location = new Point(106, 39);
            txtItemName.Name = "txtItemName";
            txtItemName.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemName.Properties.Appearance.Options.UseFont = true;
            txtItemName.Size = new Size(160, 22);
            txtItemName.TabIndex = 3;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(308, 42);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(59, 16);
            labelControl5.TabIndex = 1;
            labelControl5.Text = "Ürün Kodu";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(24, 42);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(49, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Ürün Adı";
            // 
            // OrderStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 574);
            Controls.Add(groupControl1);
            Name = "OrderStockForm";
            Text = "OrderStockForm";
            Load += OrderStockForm_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GCList).EndInit();
            ((System.ComponentModel.ISupportInitialize)GVList).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtRequiredItemCount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCList;
        private DevExpress.XtraGrid.Views.Grid.GridView GVList;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtRequiredItemCount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gCId;
        private DevExpress.XtraGrid.Columns.GridColumn gCBatchNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gCStockItemCount;
        private DevExpress.XtraGrid.Columns.GridColumn gCSeletedCount;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderLineId;
        private DevExpress.XtraGrid.Columns.GridColumn gCStockId;
        private DevExpress.XtraGrid.Columns.GridColumn gCRemainingStockCount;
        private DevExpress.XtraEditors.SimpleButton BtnDecline;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
    }
}