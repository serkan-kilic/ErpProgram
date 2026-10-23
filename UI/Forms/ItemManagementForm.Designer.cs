namespace UI
{
    partial class ItemManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManagementForm));
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
            gCCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            gCName = new DevExpress.XtraGrid.Columns.GridColumn();
            gCUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            txtItemMaxUnitPrice = new DevExpress.XtraEditors.TextEdit();
            btnItemCode = new DevExpress.XtraEditors.ButtonEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtItemMinUnitPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtItemName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            LUCategories = new DevExpress.XtraEditors.LookUpEdit();
            tabDetail = new DevExpress.XtraTab.XtraTabPage();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            txtEditItemCode = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtEditItemUnitPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            txtEditItemName = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            LUECategories = new DevExpress.XtraEditors.LookUpEdit();
            gCDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)txtItemMaxUnitPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnItemCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemMinUnitPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUCategories.Properties).BeginInit();
            tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditItemCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEditItemUnitPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEditItemName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUECategories.Properties).BeginInit();
            SuspendLayout();
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = DockStyle.Fill;
            xtraTabControl1.Location = new Point(0, 64);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = tabList;
            xtraTabControl1.Size = new Size(1325, 480);
            xtraTabControl1.TabIndex = 2;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabList, tabDetail });
            // 
            // tabList
            // 
            tabList.Controls.Add(groupControl1);
            tabList.Name = "tabList";
            tabList.Size = new Size(1323, 455);
            tabList.Text = "Liste";
            // 
            // groupControl1
            // 
            groupControl1.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl1.CaptionImageOptions.Image");
            groupControl1.Controls.Add(groupControl2);
            groupControl1.Controls.Add(panelControl2);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1323, 455);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Filtre";
            // 
            // groupControl2
            // 
            groupControl2.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl2.CaptionImageOptions.Image");
            groupControl2.Controls.Add(GCList);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 123);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(1319, 330);
            groupControl2.TabIndex = 9;
            groupControl2.Text = "Liste";
            // 
            // GCList
            // 
            GCList.Dock = DockStyle.Fill;
            GCList.Location = new Point(2, 23);
            GCList.MainView = GVList;
            GCList.Name = "GCList";
            GCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoBtnItemEdit, repoLUItem });
            GCList.Size = new Size(1315, 305);
            GCList.TabIndex = 0;
            GCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { GVList });
            // 
            // GVList
            // 
            GVList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gCEdit, gCId, gCCategoryId, gCItemCode, gCName, gCUnitPrice, gCDeleted });
            GVList.GridControl = GCList;
            GVList.Name = "GVList";
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
            gCEdit.Width = 49;
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
            gCId.Caption = "#";
            gCId.FieldName = "id";
            gCId.MinWidth = 22;
            gCId.Name = "gCId";
            gCId.Width = 82;
            // 
            // gCCategoryId
            // 
            gCCategoryId.AppearanceCell.Options.UseTextOptions = true;
            gCCategoryId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCCategoryId.Caption = "Kategori Adı";
            gCCategoryId.ColumnEdit = repoLUItem;
            gCCategoryId.FieldName = "categoryid";
            gCCategoryId.MinWidth = 22;
            gCCategoryId.Name = "gCCategoryId";
            gCCategoryId.OptionsColumn.AllowEdit = false;
            gCCategoryId.Visible = true;
            gCCategoryId.VisibleIndex = 1;
            gCCategoryId.Width = 297;
            // 
            // repoLUItem
            // 
            repoLUItem.AutoHeight = false;
            repoLUItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUItem.DisplayMember = "name";
            repoLUItem.Name = "repoLUItem";
            repoLUItem.ValueMember = "id";
            // 
            // gCItemCode
            // 
            gCItemCode.AppearanceCell.Options.UseTextOptions = true;
            gCItemCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCItemCode.Caption = "Ürün Kodu";
            gCItemCode.FieldName = "itemcode";
            gCItemCode.MinWidth = 22;
            gCItemCode.Name = "gCItemCode";
            gCItemCode.OptionsColumn.AllowEdit = false;
            gCItemCode.Visible = true;
            gCItemCode.VisibleIndex = 2;
            gCItemCode.Width = 297;
            // 
            // gCName
            // 
            gCName.AppearanceCell.Options.UseTextOptions = true;
            gCName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCName.Caption = "Ürün Adı";
            gCName.FieldName = "name";
            gCName.MinWidth = 22;
            gCName.Name = "gCName";
            gCName.OptionsColumn.AllowEdit = false;
            gCName.Visible = true;
            gCName.VisibleIndex = 3;
            gCName.Width = 297;
            // 
            // gCUnitPrice
            // 
            gCUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            gCUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCUnitPrice.Caption = "Birim Fiyat";
            gCUnitPrice.FieldName = "unitprice";
            gCUnitPrice.MinWidth = 22;
            gCUnitPrice.Name = "gCUnitPrice";
            gCUnitPrice.OptionsColumn.AllowEdit = false;
            gCUnitPrice.Visible = true;
            gCUnitPrice.VisibleIndex = 4;
            gCUnitPrice.Width = 299;
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.Controls.Add(labelControl10);
            panelControl2.Controls.Add(labelControl9);
            panelControl2.Controls.Add(txtItemMaxUnitPrice);
            panelControl2.Controls.Add(btnItemCode);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Controls.Add(txtItemMinUnitPrice);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Controls.Add(txtItemName);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Controls.Add(LUCategories);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 23);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1319, 100);
            panelControl2.TabIndex = 8;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(1156, 42);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(24, 16);
            labelControl10.TabIndex = 19;
            labelControl10.Text = "Max";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(1045, 42);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(20, 16);
            labelControl9.TabIndex = 18;
            labelControl9.Text = "Min";
            // 
            // txtItemMaxUnitPrice
            // 
            txtItemMaxUnitPrice.Location = new Point(1186, 40);
            txtItemMaxUnitPrice.Name = "txtItemMaxUnitPrice";
            txtItemMaxUnitPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            txtItemMaxUnitPrice.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemMaxUnitPrice.Properties.Appearance.Options.UseFont = true;
            txtItemMaxUnitPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtItemMaxUnitPrice.Properties.MaskSettings.Set("mask", "n2");
            txtItemMaxUnitPrice.Size = new Size(68, 22);
            txtItemMaxUnitPrice.TabIndex = 17;
            txtItemMaxUnitPrice.EditValueChanged += txtItemMaxUnitPrice_EditValueChanged;
            // 
            // btnItemCode
            // 
            btnItemCode.Location = new Point(446, 38);
            btnItemCode.Margin = new Padding(3, 2, 3, 2);
            btnItemCode.Name = "btnItemCode";
            btnItemCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            btnItemCode.Properties.Appearance.Options.UseFont = true;
            btnItemCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnItemCode.Size = new Size(160, 22);
            btnItemCode.TabIndex = 16;
            btnItemCode.ButtonClick += btnItemCode_ButtonClick;
            btnItemCode.EditValueChanged += btnItemCode_EditValueChanged;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(941, 42);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(63, 16);
            labelControl4.TabIndex = 15;
            labelControl4.Text = "Birim Fiyatı";
            // 
            // txtItemMinUnitPrice
            // 
            txtItemMinUnitPrice.Location = new Point(1072, 40);
            txtItemMinUnitPrice.Name = "txtItemMinUnitPrice";
            txtItemMinUnitPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            txtItemMinUnitPrice.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemMinUnitPrice.Properties.Appearance.Options.UseFont = true;
            txtItemMinUnitPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtItemMinUnitPrice.Properties.MaskSettings.Set("mask", "n2");
            txtItemMinUnitPrice.Size = new Size(68, 22);
            txtItemMinUnitPrice.TabIndex = 14;
            txtItemMinUnitPrice.EditValueChanged += txtItemMinUnitPrice_EditValueChanged;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(636, 42);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(49, 16);
            labelControl3.TabIndex = 13;
            labelControl3.Text = "Ürün Adı";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(753, 38);
            txtItemName.Name = "txtItemName";
            txtItemName.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtItemName.Properties.Appearance.Options.UseFont = true;
            txtItemName.Properties.ReadOnly = true;
            txtItemName.Size = new Size(160, 22);
            txtItemName.TabIndex = 12;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(326, 42);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(59, 16);
            labelControl2.TabIndex = 11;
            labelControl2.Text = "Ürün Kodu";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(24, 42);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(47, 16);
            labelControl1.TabIndex = 10;
            labelControl1.Text = "Kategori";
            // 
            // LUCategories
            // 
            LUCategories.Location = new Point(141, 38);
            LUCategories.Name = "LUCategories";
            LUCategories.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUCategories.Properties.Appearance.Options.UseFont = true;
            LUCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUCategories.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "#", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Kategoriler", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            LUCategories.Properties.DisplayMember = "name";
            LUCategories.Properties.NullText = "Kategori Seçiniz";
            LUCategories.Properties.ValueMember = "id";
            LUCategories.Size = new Size(160, 22);
            LUCategories.TabIndex = 9;
            LUCategories.EditValueChanged += LUCategories_EditValueChanged;
            // 
            // tabDetail
            // 
            tabDetail.Controls.Add(groupControl3);
            tabDetail.Name = "tabDetail";
            tabDetail.Size = new Size(1323, 455);
            tabDetail.Text = "Detay";
            // 
            // groupControl3
            // 
            groupControl3.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl3.CaptionImageOptions.Image");
            groupControl3.Controls.Add(panelControl3);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(0, 0);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(1323, 455);
            groupControl3.TabIndex = 2;
            groupControl3.Text = "Düzenle";
            // 
            // panelControl3
            // 
            panelControl3.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl3.Controls.Add(txtEditItemCode);
            panelControl3.Controls.Add(labelControl5);
            panelControl3.Controls.Add(txtEditItemUnitPrice);
            panelControl3.Controls.Add(labelControl6);
            panelControl3.Controls.Add(txtEditItemName);
            panelControl3.Controls.Add(labelControl7);
            panelControl3.Controls.Add(labelControl8);
            panelControl3.Controls.Add(LUECategories);
            panelControl3.Dock = DockStyle.Fill;
            panelControl3.Location = new Point(2, 23);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(1319, 430);
            panelControl3.TabIndex = 8;
            // 
            // txtEditItemCode
            // 
            txtEditItemCode.Location = new Point(447, 38);
            txtEditItemCode.Margin = new Padding(3, 2, 3, 2);
            txtEditItemCode.Name = "txtEditItemCode";
            txtEditItemCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditItemCode.Properties.Appearance.Options.UseFont = true;
            txtEditItemCode.Size = new Size(160, 22);
            txtEditItemCode.TabIndex = 17;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(941, 42);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(63, 16);
            labelControl5.TabIndex = 15;
            labelControl5.Text = "Birim Fiyatı";
            // 
            // txtEditItemUnitPrice
            // 
            txtEditItemUnitPrice.Location = new Point(1058, 41);
            txtEditItemUnitPrice.Name = "txtEditItemUnitPrice";
            txtEditItemUnitPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            txtEditItemUnitPrice.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditItemUnitPrice.Properties.Appearance.Options.UseFont = true;
            txtEditItemUnitPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtEditItemUnitPrice.Properties.MaskSettings.Set("mask", "n2");
            txtEditItemUnitPrice.Properties.NullText = "0";
            txtEditItemUnitPrice.Size = new Size(160, 22);
            txtEditItemUnitPrice.TabIndex = 14;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(636, 42);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(49, 16);
            labelControl6.TabIndex = 13;
            labelControl6.Text = "Ürün Adı";
            // 
            // txtEditItemName
            // 
            txtEditItemName.Location = new Point(753, 38);
            txtEditItemName.Name = "txtEditItemName";
            txtEditItemName.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditItemName.Properties.Appearance.Options.UseFont = true;
            txtEditItemName.Size = new Size(160, 22);
            txtEditItemName.TabIndex = 12;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(326, 42);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(59, 16);
            labelControl7.TabIndex = 11;
            labelControl7.Text = "Ürün Kodu";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(24, 42);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(47, 16);
            labelControl8.TabIndex = 10;
            labelControl8.Text = "Kategori";
            // 
            // LUECategories
            // 
            LUECategories.Location = new Point(141, 38);
            LUECategories.Name = "LUECategories";
            LUECategories.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUECategories.Properties.Appearance.Options.UseFont = true;
            LUECategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUECategories.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "#", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Kategoriler", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            LUECategories.Properties.DisplayMember = "name";
            LUECategories.Properties.NullText = "Kategori Seçiniz";
            LUECategories.Properties.ValueMember = "id";
            LUECategories.Size = new Size(160, 22);
            LUECategories.TabIndex = 9;
            // 
            // gCDeleted
            // 
            gCDeleted.Caption = "Silindi mi";
            gCDeleted.FieldName = "deleted";
            gCDeleted.Name = "gCDeleted";
            // 
            // ItemManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 544);
            Controls.Add(xtraTabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemManagementForm";
            Text = "Yönetim Sayfası";
            Load += ItemManagementForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)txtItemMaxUnitPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnItemCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemMinUnitPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUCategories.Properties).EndInit();
            tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditItemCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEditItemUnitPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEditItemName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUECategories.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabList;
        private DevExpress.XtraTab.XtraTabPage tabDetail;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEditItemUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEditItemName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit LUECategories;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtItemMinUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LUCategories;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl GCList;
        private DevExpress.XtraGrid.Views.Grid.GridView GVList;
        private DevExpress.XtraGrid.Columns.GridColumn gCId;
        private DevExpress.XtraGrid.Columns.GridColumn gCCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn gCItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn gCName;
        private DevExpress.XtraGrid.Columns.GridColumn gCUnitPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnItemEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gCEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUItem;
        private DevExpress.XtraEditors.ButtonEdit btnItemCode;
        private DevExpress.XtraEditors.TextEdit txtEditItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemMaxUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.Columns.GridColumn gCDeleted;
    }
}