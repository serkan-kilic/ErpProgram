namespace UI
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            tabList = new DevExpress.XtraTab.XtraTabPage();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            GCList = new DevExpress.XtraGrid.GridControl();
            GVList = new DevExpress.XtraGrid.Views.Grid.GridView();
            gCEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            repoBtnItemEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gCId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCBatchNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            gCItemCount = new DevExpress.XtraGrid.Columns.GridColumn();
            gCDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtItemMaxCount = new DevExpress.XtraEditors.TextEdit();
            btnItemCode = new DevExpress.XtraEditors.ButtonEdit();
            txtItemMinCount = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            tabDetail = new DevExpress.XtraTab.XtraTabPage();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            txtEditBatchNumber = new DevExpress.XtraEditors.TextEdit();
            txtEditItemCount = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            btnEditItemCode = new DevExpress.XtraEditors.ButtonEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GCList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GVList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnItemEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtItemMaxCount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnItemCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemMinCount.Properties).BeginInit();
            tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditBatchNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEditItemCount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEditItemCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = DockStyle.Fill;
            xtraTabControl1.Location = new Point(0, 64);
            xtraTabControl1.Margin = new Padding(3, 2, 3, 2);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = tabList;
            xtraTabControl1.Size = new Size(1051, 405);
            xtraTabControl1.TabIndex = 2;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabList, tabDetail });
            // 
            // tabList
            // 
            tabList.Controls.Add(groupControl1);
            tabList.Margin = new Padding(3, 2, 3, 2);
            tabList.Name = "tabList";
            tabList.Size = new Size(1049, 380);
            tabList.Text = "Liste";
            // 
            // groupControl1
            // 
            groupControl1.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl1.CaptionImageOptions.Image");
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(panelControl2);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(3, 2, 3, 2);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1049, 380);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Filtre";
            // 
            // groupControl2
            // 
            groupControl2.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl2.CaptionImageOptions.Image");
            groupControl2.Controls.Add(GCList);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 123);
            groupControl2.Margin = new Padding(3, 2, 3, 2);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(1045, 255);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Liste";
            // 
            // GCList
            // 
            GCList.Dock = DockStyle.Fill;
            GCList.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            GCList.Location = new Point(2, 23);
            GCList.MainView = GVList;
            GCList.Margin = new Padding(3, 2, 3, 2);
            GCList.Name = "GCList";
            GCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoBtnItemEdit, repoLUItem });
            GCList.Size = new Size(1041, 230);
            GCList.TabIndex = 0;
            GCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { GVList });
            // 
            // GVList
            // 
            GVList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gCEdit, gCId, gCItemId, gCBatchNumber, gCItemCount, gCDeleted });
            GVList.DetailHeight = 262;
            GVList.GridControl = GCList;
            GVList.Name = "GVList";
            GVList.OptionsEditForm.PopupEditFormWidth = 700;
            GVList.OptionsView.ShowGroupPanel = false;
            // 
            // gCEdit
            // 
            gCEdit.Caption = "Detay";
            gCEdit.ColumnEdit = repoBtnItemEdit;
            gCEdit.MinWidth = 22;
            gCEdit.Name = "gCEdit";
            gCEdit.Visible = true;
            gCEdit.VisibleIndex = 0;
            gCEdit.Width = 43;
            // 
            // repoBtnItemEdit
            // 
            repoBtnItemEdit.AutoHeight = false;
            editorButtonImageOptions1.ImageUri.Uri = "spreadsheet/linecolor";
            repoBtnItemEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repoBtnItemEdit.Name = "repoBtnItemEdit";
            repoBtnItemEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repoBtnItemEdit.ButtonClick += repoBtnItemEdit_ButtonClick;
            // 
            // gCId
            // 
            gCId.Caption = "id";
            gCId.FieldName = "id";
            gCId.MinWidth = 22;
            gCId.Name = "gCId";
            gCId.Width = 82;
            // 
            // gCItemId
            // 
            gCItemId.AppearanceCell.Options.UseTextOptions = true;
            gCItemId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCItemId.Caption = "Ürün Kodu";
            gCItemId.ColumnEdit = repoLUItem;
            gCItemId.FieldName = "itemid";
            gCItemId.Name = "gCItemId";
            gCItemId.OptionsColumn.AllowEdit = false;
            gCItemId.Visible = true;
            gCItemId.VisibleIndex = 1;
            gCItemId.Width = 326;
            // 
            // repoLUItem
            // 
            repoLUItem.AutoHeight = false;
            repoLUItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUItem.DisplayMember = "itemcode";
            repoLUItem.Name = "repoLUItem";
            repoLUItem.ValueMember = "id";
            // 
            // gCBatchNumber
            // 
            gCBatchNumber.AppearanceCell.Options.UseTextOptions = true;
            gCBatchNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCBatchNumber.Caption = "Parti Numarası";
            gCBatchNumber.FieldName = "batchnumber";
            gCBatchNumber.Name = "gCBatchNumber";
            gCBatchNumber.Visible = true;
            gCBatchNumber.VisibleIndex = 2;
            gCBatchNumber.Width = 326;
            // 
            // gCItemCount
            // 
            gCItemCount.AppearanceCell.Options.UseTextOptions = true;
            gCItemCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCItemCount.Caption = "Ürün Sayısı";
            gCItemCount.FieldName = "itemcount";
            gCItemCount.Name = "gCItemCount";
            gCItemCount.OptionsColumn.AllowEdit = false;
            gCItemCount.Visible = true;
            gCItemCount.VisibleIndex = 3;
            gCItemCount.Width = 323;
            // 
            // gCDeleted
            // 
            gCDeleted.Caption = "Silindi mi";
            gCDeleted.FieldName = "deleted";
            gCDeleted.Name = "gCDeleted";
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.Controls.Add(labelControl6);
            panelControl2.Controls.Add(labelControl5);
            panelControl2.Controls.Add(txtItemMaxCount);
            panelControl2.Controls.Add(btnItemCode);
            panelControl2.Controls.Add(txtItemMinCount);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 23);
            panelControl2.Margin = new Padding(3, 2, 3, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1045, 100);
            panelControl2.TabIndex = 0;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(416, 40);
            labelControl6.Margin = new Padding(3, 2, 3, 2);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(20, 16);
            labelControl6.TabIndex = 9;
            labelControl6.Text = "Min";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(528, 40);
            labelControl5.Margin = new Padding(3, 2, 3, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(24, 16);
            labelControl5.TabIndex = 8;
            labelControl5.Text = "Max";
            // 
            // txtItemMaxCount
            // 
            txtItemMaxCount.Location = new Point(557, 38);
            txtItemMaxCount.Margin = new Padding(3, 2, 3, 2);
            txtItemMaxCount.Name = "txtItemMaxCount";
            txtItemMaxCount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            txtItemMaxCount.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemMaxCount.Properties.Appearance.Options.UseFont = true;
            txtItemMaxCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtItemMaxCount.Properties.MaskSettings.Set("mask", "d0");
            txtItemMaxCount.Size = new Size(64, 22);
            txtItemMaxCount.TabIndex = 7;
            txtItemMaxCount.EditValueChanged += txtItemMaxCount_EditValueChanged;
            // 
            // btnItemCode
            // 
            btnItemCode.Location = new Point(141, 38);
            btnItemCode.Margin = new Padding(3, 2, 3, 2);
            btnItemCode.Name = "btnItemCode";
            btnItemCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            btnItemCode.Properties.Appearance.Options.UseFont = true;
            btnItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnItemCode.Size = new Size(160, 22);
            btnItemCode.TabIndex = 6;
            btnItemCode.ButtonClick += btnItemCode_ButtonClick;
            btnItemCode.EditValueChanged += btnItemCode_EditValueChanged;
            // 
            // txtItemMinCount
            // 
            txtItemMinCount.Location = new Point(446, 38);
            txtItemMinCount.Margin = new Padding(3, 2, 3, 2);
            txtItemMinCount.Name = "txtItemMinCount";
            txtItemMinCount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            txtItemMinCount.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemMinCount.Properties.Appearance.Options.UseFont = true;
            txtItemMinCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtItemMinCount.Properties.MaskSettings.Set("mask", "d0");
            txtItemMinCount.Size = new Size(64, 22);
            txtItemMinCount.TabIndex = 3;
            txtItemMinCount.EditValueChanged += txtItemMinCount_EditValueChanged;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(325, 40);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(64, 16);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Ürün Sayısı";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(22, 40);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(59, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Ürün Kodu";
            // 
            // tabDetail
            // 
            tabDetail.Controls.Add(groupControl3);
            tabDetail.Margin = new Padding(3, 2, 3, 2);
            tabDetail.Name = "tabDetail";
            tabDetail.Size = new Size(1049, 380);
            tabDetail.Text = "Detay";
            // 
            // groupControl3
            // 
            groupControl3.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl3.CaptionImageOptions.Image");
            groupControl3.Controls.Add(panelControl3);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(0, 0);
            groupControl3.Margin = new Padding(3, 2, 3, 2);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(1049, 380);
            groupControl3.TabIndex = 1;
            groupControl3.Text = "Düzenle";
            // 
            // panelControl3
            // 
            panelControl3.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl3.Controls.Add(txtEditBatchNumber);
            panelControl3.Controls.Add(txtEditItemCount);
            panelControl3.Controls.Add(labelControl7);
            panelControl3.Controls.Add(btnEditItemCode);
            panelControl3.Controls.Add(labelControl3);
            panelControl3.Controls.Add(labelControl4);
            panelControl3.Dock = DockStyle.Fill;
            panelControl3.Location = new Point(2, 23);
            panelControl3.Margin = new Padding(3, 2, 3, 2);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(1045, 355);
            panelControl3.TabIndex = 0;
            // 
            // txtEditBatchNumber
            // 
            txtEditBatchNumber.Location = new Point(427, 38);
            txtEditBatchNumber.Name = "txtEditBatchNumber";
            txtEditBatchNumber.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditBatchNumber.Properties.Appearance.Options.UseFont = true;
            txtEditBatchNumber.Size = new Size(160, 22);
            txtEditBatchNumber.TabIndex = 7;
            // 
            // txtEditItemCount
            // 
            txtEditItemCount.Location = new Point(766, 38);
            txtEditItemCount.Margin = new Padding(3, 2, 3, 2);
            txtEditItemCount.Name = "txtEditItemCount";
            txtEditItemCount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            txtEditItemCount.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditItemCount.Properties.Appearance.Options.UseFont = true;
            txtEditItemCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtEditItemCount.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtEditItemCount.Properties.MaskSettings.Set("mask", "n0");
            txtEditItemCount.Properties.NullText = "0";
            txtEditItemCount.Size = new Size(160, 22);
            txtEditItemCount.TabIndex = 6;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(645, 40);
            labelControl7.Margin = new Padding(3, 2, 3, 2);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(64, 16);
            labelControl7.TabIndex = 5;
            labelControl7.Text = "Ürün Sayısı";
            // 
            // btnEditItemCode
            // 
            btnEditItemCode.Location = new Point(141, 38);
            btnEditItemCode.Margin = new Padding(3, 2, 3, 2);
            btnEditItemCode.Name = "btnEditItemCode";
            btnEditItemCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            btnEditItemCode.Properties.Appearance.Options.UseFont = true;
            btnEditItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph) });
            btnEditItemCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnEditItemCode.Size = new Size(160, 22);
            btnEditItemCode.TabIndex = 4;
            btnEditItemCode.ButtonClick += btnEditItemName_ButtonClick;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(325, 40);
            labelControl3.Margin = new Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(58, 16);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Parti Kodu";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(22, 40);
            labelControl4.Margin = new Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(59, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Ürün Kodu";
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 469);
            Controls.Add(xtraTabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StockForm";
            Text = "Yönetim Sayfası";
            Load += StockForm_Load;
            Controls.SetChildIndex(xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GCList).EndInit();
            ((System.ComponentModel.ISupportInitialize)GVList).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnItemEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtItemMaxCount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnItemCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemMinCount.Properties).EndInit();
            tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditBatchNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEditItemCount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEditItemCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabList;
        private DevExpress.XtraTab.XtraTabPage tabDetail;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GCList;
        private DevExpress.XtraGrid.Views.Grid.GridView GVList;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtItemMinCount;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gCEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnItemEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gCId;
        private DevExpress.XtraGrid.Columns.GridColumn gCItemId;
        private DevExpress.XtraGrid.Columns.GridColumn gCItemCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUItem;
        private DevExpress.XtraEditors.ButtonEdit btnItemCode;
        private DevExpress.XtraEditors.ButtonEdit btnEditItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemMaxCount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn gCDeleted;
        private DevExpress.XtraEditors.TextEdit txtEditItemCount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtEditBatchNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gCBatchNumber;
    }
}