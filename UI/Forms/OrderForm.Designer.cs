namespace UI.Forms
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            tabList = new DevExpress.XtraTab.XtraTabPage();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            GCList = new DevExpress.XtraGrid.GridControl();
            GVList = new DevExpress.XtraGrid.Views.Grid.GridView();
            gCEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            repoBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gCId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCCustomerTCKN = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUTCKN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCCustomerVKN = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUVKN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCOrderType = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUOrderType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCPaymentId = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUPayment = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUOrderStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            gCOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            gCCompletedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            gCOrderTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gCOrderDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnOrderCode = new DevExpress.XtraEditors.ButtonEdit();
            btnTCKNVKN = new DevExpress.XtraEditors.ButtonEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            LUOrderStatus = new DevExpress.XtraEditors.LookUpEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            LUPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            LUOrderType = new DevExpress.XtraEditors.LookUpEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            tabDetail = new DevExpress.XtraTab.XtraTabPage();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            groupControl5 = new DevExpress.XtraEditors.GroupControl();
            gCOrderLineList = new DevExpress.XtraGrid.GridControl();
            gVOrderLineList = new DevExpress.XtraGrid.Views.Grid.GridView();
            gCOrderLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            gCStockEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            repoBtnStockEntry = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gCOrderLineItem = new DevExpress.XtraGrid.Columns.GridColumn();
            repoBtnItemSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gCOrderLineOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            repoLUOrder = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            gCUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gCOrderLineItemTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gCOrderLineItemCount = new DevExpress.XtraGrid.Columns.GridColumn();
            gCDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            gCDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            repoOrderlineDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            txtEditOrderCode = new DevExpress.XtraEditors.TextEdit();
            txtOrderTotalPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl16 = new DevExpress.XtraEditors.LabelControl();
            labelControl15 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            LUEOrderStatus = new DevExpress.XtraEditors.LookUpEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            LUEPaymentType = new DevExpress.XtraEditors.LookUpEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            LUEOrderType = new DevExpress.XtraEditors.LookUpEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            BtnEditTCKNVKN = new DevExpress.XtraEditors.ButtonEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            txtEditOrderDate = new DevExpress.XtraEditors.DateEdit();
            txtCompletedDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GCList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GVList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUTCKN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUVKN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUOrderType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUOrderStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnOrderCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTCKNVKN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUOrderStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUPaymentType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUOrderType.Properties).BeginInit();
            tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl5).BeginInit();
            groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCOrderLineList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gVOrderLineList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnStockEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnItemSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoOrderlineDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditOrderCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOrderTotalPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUEOrderStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUEPaymentType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LUEOrderType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnEditTCKNVKN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEditOrderDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEditOrderDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCompletedDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCompletedDate.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = DockStyle.Fill;
            xtraTabControl1.Location = new Point(0, 64);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = tabList;
            xtraTabControl1.Size = new Size(1924, 616);
            xtraTabControl1.TabIndex = 2;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabList, tabDetail });
            // 
            // tabList
            // 
            tabList.Controls.Add(groupControl1);
            tabList.Name = "tabList";
            tabList.Size = new Size(1922, 591);
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
            groupControl1.Size = new Size(1922, 591);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Filtre";
            // 
            // groupControl2
            // 
            groupControl2.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl2.CaptionImageOptions.Image");
            groupControl2.Controls.Add(GCList);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(2, 123);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(1918, 466);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Liste";
            // 
            // GCList
            // 
            GCList.Dock = DockStyle.Fill;
            GCList.Location = new Point(2, 23);
            GCList.MainView = GVList;
            GCList.Name = "GCList";
            GCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoBtnEdit, repoLUPayment, repoLUOrderType, repoLUOrderStatus, repoLUTCKN, repoLUVKN });
            GCList.Size = new Size(1914, 441);
            GCList.TabIndex = 0;
            GCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { GVList });
            // 
            // GVList
            // 
            GVList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gCEdit, gCId, gCCustomerTCKN, gCCustomerVKN, gCOrderType, gCPaymentId, gCOrderStatus, gCOrderCode, gCOrderDate, gCCompletedDate, gCOrderTotalPrice, gCOrderDeleted });
            GVList.GridControl = GCList;
            GVList.Name = "GVList";
            GVList.OptionsView.ShowGroupPanel = false;
            // 
            // gCEdit
            // 
            gCEdit.AppearanceCell.Options.UseTextOptions = true;
            gCEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCEdit.Caption = "Detay";
            gCEdit.ColumnEdit = repoBtnEdit;
            gCEdit.Name = "gCEdit";
            gCEdit.Visible = true;
            gCEdit.VisibleIndex = 0;
            gCEdit.Width = 51;
            // 
            // repoBtnEdit
            // 
            repoBtnEdit.AutoHeight = false;
            editorButtonImageOptions1.ImageUri.Uri = "spreadsheet/linecolor";
            repoBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repoBtnEdit.Name = "repoBtnEdit";
            repoBtnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repoBtnEdit.ButtonClick += repoBtnEdit_ButtonClick;
            // 
            // gCId
            // 
            gCId.AppearanceCell.Options.UseTextOptions = true;
            gCId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCId.Caption = "Id";
            gCId.FieldName = "id";
            gCId.Name = "gCId";
            gCId.OptionsColumn.AllowEdit = false;
            // 
            // gCCustomerTCKN
            // 
            gCCustomerTCKN.AppearanceCell.Options.UseTextOptions = true;
            gCCustomerTCKN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCCustomerTCKN.Caption = "Müşteri TCKN";
            gCCustomerTCKN.ColumnEdit = repoLUTCKN;
            gCCustomerTCKN.FieldName = "customerid";
            gCCustomerTCKN.Name = "gCCustomerTCKN";
            gCCustomerTCKN.OptionsColumn.AllowEdit = false;
            gCCustomerTCKN.Visible = true;
            gCCustomerTCKN.VisibleIndex = 1;
            gCCustomerTCKN.Width = 201;
            // 
            // repoLUTCKN
            // 
            repoLUTCKN.AutoHeight = false;
            repoLUTCKN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUTCKN.DisplayMember = "tckn";
            repoLUTCKN.Name = "repoLUTCKN";
            repoLUTCKN.ValueMember = "id";
            // 
            // gCCustomerVKN
            // 
            gCCustomerVKN.AppearanceCell.Options.UseTextOptions = true;
            gCCustomerVKN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCCustomerVKN.Caption = "Müşteri VKN";
            gCCustomerVKN.ColumnEdit = repoLUVKN;
            gCCustomerVKN.FieldName = "customerid";
            gCCustomerVKN.Name = "gCCustomerVKN";
            gCCustomerVKN.OptionsColumn.AllowEdit = false;
            gCCustomerVKN.Visible = true;
            gCCustomerVKN.VisibleIndex = 2;
            gCCustomerVKN.Width = 201;
            // 
            // repoLUVKN
            // 
            repoLUVKN.AutoHeight = false;
            repoLUVKN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUVKN.DisplayMember = "vkn";
            repoLUVKN.Name = "repoLUVKN";
            repoLUVKN.ValueMember = "id";
            // 
            // gCOrderType
            // 
            gCOrderType.AppearanceCell.Options.UseTextOptions = true;
            gCOrderType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderType.Caption = "Sipariş Tipi";
            gCOrderType.ColumnEdit = repoLUOrderType;
            gCOrderType.FieldName = "ordertypeid";
            gCOrderType.Name = "gCOrderType";
            gCOrderType.OptionsColumn.AllowEdit = false;
            gCOrderType.Visible = true;
            gCOrderType.VisibleIndex = 3;
            gCOrderType.Width = 201;
            // 
            // repoLUOrderType
            // 
            repoLUOrderType.AutoHeight = false;
            repoLUOrderType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUOrderType.DisplayMember = "name";
            repoLUOrderType.Name = "repoLUOrderType";
            repoLUOrderType.ValueMember = "id";
            // 
            // gCPaymentId
            // 
            gCPaymentId.AppearanceCell.Options.UseTextOptions = true;
            gCPaymentId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCPaymentId.Caption = "Ödeme Tipi";
            gCPaymentId.ColumnEdit = repoLUPayment;
            gCPaymentId.FieldName = "paymentid";
            gCPaymentId.Name = "gCPaymentId";
            gCPaymentId.OptionsColumn.AllowEdit = false;
            gCPaymentId.Visible = true;
            gCPaymentId.VisibleIndex = 4;
            gCPaymentId.Width = 201;
            // 
            // repoLUPayment
            // 
            repoLUPayment.AutoHeight = false;
            repoLUPayment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUPayment.DisplayMember = "name";
            repoLUPayment.Name = "repoLUPayment";
            repoLUPayment.ValueMember = "id";
            // 
            // gCOrderStatus
            // 
            gCOrderStatus.AppearanceCell.Options.UseTextOptions = true;
            gCOrderStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderStatus.Caption = "Sipariş Durumu";
            gCOrderStatus.ColumnEdit = repoLUOrderStatus;
            gCOrderStatus.FieldName = "orderstatusid";
            gCOrderStatus.Name = "gCOrderStatus";
            gCOrderStatus.OptionsColumn.AllowEdit = false;
            gCOrderStatus.Visible = true;
            gCOrderStatus.VisibleIndex = 5;
            gCOrderStatus.Width = 201;
            // 
            // repoLUOrderStatus
            // 
            repoLUOrderStatus.AutoHeight = false;
            repoLUOrderStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUOrderStatus.DisplayMember = "name";
            repoLUOrderStatus.Name = "repoLUOrderStatus";
            repoLUOrderStatus.ValueMember = "id";
            // 
            // gCOrderCode
            // 
            gCOrderCode.AppearanceCell.Options.UseTextOptions = true;
            gCOrderCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderCode.Caption = "Sipariş Kodu";
            gCOrderCode.FieldName = "ordercode";
            gCOrderCode.Name = "gCOrderCode";
            gCOrderCode.OptionsColumn.AllowEdit = false;
            gCOrderCode.Visible = true;
            gCOrderCode.VisibleIndex = 6;
            gCOrderCode.Width = 201;
            // 
            // gCOrderDate
            // 
            gCOrderDate.AppearanceCell.Options.UseTextOptions = true;
            gCOrderDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderDate.Caption = "Sipariş Verilme Tarihi";
            gCOrderDate.FieldName = "orderdate";
            gCOrderDate.Name = "gCOrderDate";
            gCOrderDate.OptionsColumn.AllowEdit = false;
            gCOrderDate.Visible = true;
            gCOrderDate.VisibleIndex = 7;
            gCOrderDate.Width = 201;
            // 
            // gCCompletedDate
            // 
            gCCompletedDate.AppearanceCell.Options.UseTextOptions = true;
            gCCompletedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCCompletedDate.Caption = "Sipariş Tamamlanma Tarihi";
            gCCompletedDate.FieldName = "completeddate";
            gCCompletedDate.Name = "gCCompletedDate";
            gCCompletedDate.OptionsColumn.AllowEdit = false;
            gCCompletedDate.Visible = true;
            gCCompletedDate.VisibleIndex = 8;
            gCCompletedDate.Width = 201;
            // 
            // gCOrderTotalPrice
            // 
            gCOrderTotalPrice.AppearanceCell.Options.UseTextOptions = true;
            gCOrderTotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderTotalPrice.Caption = "Sipariş Toplam Fiyatı";
            gCOrderTotalPrice.FieldName = "ordertotalprice";
            gCOrderTotalPrice.Name = "gCOrderTotalPrice";
            gCOrderTotalPrice.OptionsColumn.AllowEdit = false;
            gCOrderTotalPrice.Visible = true;
            gCOrderTotalPrice.VisibleIndex = 9;
            gCOrderTotalPrice.Width = 232;
            // 
            // gCOrderDeleted
            // 
            gCOrderDeleted.Caption = "Silindi mi";
            gCOrderDeleted.FieldName = "deleted";
            gCOrderDeleted.Name = "gCOrderDeleted";
            // 
            // panelControl2
            // 
            panelControl2.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl2.Appearance.Options.UseBackColor = true;
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.Controls.Add(btnOrderCode);
            panelControl2.Controls.Add(btnTCKNVKN);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(LUOrderStatus);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Controls.Add(labelControl5);
            panelControl2.Controls.Add(LUPaymentType);
            panelControl2.Controls.Add(LUOrderType);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Dock = DockStyle.Top;
            panelControl2.Location = new Point(2, 23);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1918, 100);
            panelControl2.TabIndex = 0;
            // 
            // btnOrderCode
            // 
            btnOrderCode.Location = new Point(467, 38);
            btnOrderCode.Name = "btnOrderCode";
            btnOrderCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            btnOrderCode.Properties.Appearance.Options.UseFont = true;
            btnOrderCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnOrderCode.Size = new Size(160, 22);
            btnOrderCode.TabIndex = 28;
            btnOrderCode.ButtonClick += btnOrderCode_ButtonClick;
            btnOrderCode.EditValueChanged += btnOrderCode_EditValueChanged;
            // 
            // btnTCKNVKN
            // 
            btnTCKNVKN.Location = new Point(141, 38);
            btnTCKNVKN.Name = "btnTCKNVKN";
            btnTCKNVKN.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            btnTCKNVKN.Properties.Appearance.Options.UseFont = true;
            btnTCKNVKN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnTCKNVKN.Size = new Size(160, 22);
            btnTCKNVKN.TabIndex = 1;
            btnTCKNVKN.ButtonClick += btnTCKNVKN_ButtonClick;
            btnTCKNVKN.EditValueChanged += btnTCKNVKN_EditValueChanged;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(340, 40);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(71, 16);
            labelControl2.TabIndex = 27;
            labelControl2.Text = "Sipariş Kodu";
            // 
            // LUOrderStatus
            // 
            LUOrderStatus.Location = new Point(1402, 38);
            LUOrderStatus.Name = "LUOrderStatus";
            LUOrderStatus.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUOrderStatus.Properties.Appearance.Options.UseFont = true;
            LUOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUOrderStatus.Properties.DisplayMember = "name";
            LUOrderStatus.Properties.NullText = "";
            LUOrderStatus.Properties.ValueMember = "id";
            LUOrderStatus.Size = new Size(160, 22);
            LUOrderStatus.TabIndex = 26;
            LUOrderStatus.EditValueChanged += LUOrderStatus_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(22, 40);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(105, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Müşteri TCKN/VKN";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(1277, 40);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(88, 16);
            labelControl3.TabIndex = 25;
            labelControl3.Text = "Sipariş Durumu";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(659, 41);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(70, 16);
            labelControl5.TabIndex = 21;
            labelControl5.Text = "Sipariş Türü";
            // 
            // LUPaymentType
            // 
            LUPaymentType.Location = new Point(1085, 39);
            LUPaymentType.Name = "LUPaymentType";
            LUPaymentType.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUPaymentType.Properties.Appearance.Options.UseFont = true;
            LUPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUPaymentType.Properties.DisplayMember = "name";
            LUPaymentType.Properties.NullText = "";
            LUPaymentType.Properties.ValueMember = "id";
            LUPaymentType.Size = new Size(160, 22);
            LUPaymentType.TabIndex = 24;
            LUPaymentType.EditValueChanged += LUPaymentType_EditValueChanged;
            // 
            // LUOrderType
            // 
            LUOrderType.Location = new Point(780, 39);
            LUOrderType.Name = "LUOrderType";
            LUOrderType.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUOrderType.Properties.Appearance.Options.UseFont = true;
            LUOrderType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUOrderType.Properties.DisplayMember = "name";
            LUOrderType.Properties.NullText = "";
            LUOrderType.Properties.ValueMember = "id";
            LUOrderType.Size = new Size(160, 22);
            LUOrderType.TabIndex = 22;
            LUOrderType.EditValueChanged += LUOrderType_EditValueChanged;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(962, 41);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(72, 16);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "Ödeme Türü";
            // 
            // tabDetail
            // 
            tabDetail.Controls.Add(groupControl3);
            tabDetail.Name = "tabDetail";
            tabDetail.Size = new Size(1922, 591);
            tabDetail.Text = "Detay";
            // 
            // groupControl3
            // 
            groupControl3.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl3.CaptionImageOptions.Image");
            groupControl3.Controls.Add(groupControl5);
            groupControl3.Controls.Add(panelControl3);
            groupControl3.Dock = DockStyle.Fill;
            groupControl3.Location = new Point(0, 0);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(1922, 591);
            groupControl3.TabIndex = 0;
            groupControl3.Text = "Düzenle";
            // 
            // groupControl5
            // 
            groupControl5.CaptionImageOptions.Image = (Image)resources.GetObject("groupControl5.CaptionImageOptions.Image");
            groupControl5.Controls.Add(gCOrderLineList);
            groupControl5.Dock = DockStyle.Fill;
            groupControl5.Location = new Point(2, 153);
            groupControl5.Name = "groupControl5";
            groupControl5.Size = new Size(1918, 436);
            groupControl5.TabIndex = 1;
            groupControl5.Text = "Liste";
            // 
            // gCOrderLineList
            // 
            gCOrderLineList.Dock = DockStyle.Fill;
            gCOrderLineList.Location = new Point(2, 23);
            gCOrderLineList.MainView = gVOrderLineList;
            gCOrderLineList.Name = "gCOrderLineList";
            gCOrderLineList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoLUOrder, repoOrderlineDelete, repoBtnItemSelect, repoBtnStockEntry });
            gCOrderLineList.Size = new Size(1914, 411);
            gCOrderLineList.TabIndex = 0;
            gCOrderLineList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gVOrderLineList });
            // 
            // gVOrderLineList
            // 
            gVOrderLineList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gCOrderLineId, gCItemId, gCStockEntry, gCOrderLineItem, gCOrderLineOrder, gCUnitPrice, gCOrderLineItemTotalPrice, gCOrderLineItemCount, gCDeleted, gCDelete });
            gVOrderLineList.GridControl = gCOrderLineList;
            gVOrderLineList.Name = "gVOrderLineList";
            gVOrderLineList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gVOrderLineList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gVOrderLineList.OptionsView.ShowGroupPanel = false;
            gVOrderLineList.InitNewRow += gVOrderLineList_InitNewRow;
            gVOrderLineList.FocusedRowChanged += gVOrderLineList_FocusedRowChanged;
            gVOrderLineList.CellValueChanged += gVOrderLineList_CellValueChanged;
            // 
            // gCOrderLineId
            // 
            gCOrderLineId.AppearanceCell.Options.UseTextOptions = true;
            gCOrderLineId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderLineId.Caption = "Id";
            gCOrderLineId.FieldName = "id";
            gCOrderLineId.Name = "gCOrderLineId";
            // 
            // gCItemId
            // 
            gCItemId.FieldName = "itemid";
            gCItemId.Name = "gCItemId";
            // 
            // gCStockEntry
            // 
            gCStockEntry.Caption = "Stok Girişi";
            gCStockEntry.ColumnEdit = repoBtnStockEntry;
            gCStockEntry.Name = "gCStockEntry";
            gCStockEntry.Visible = true;
            gCStockEntry.VisibleIndex = 0;
            gCStockEntry.Width = 67;
            // 
            // repoBtnStockEntry
            // 
            repoBtnStockEntry.AutoHeight = false;
            repoBtnStockEntry.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus) });
            repoBtnStockEntry.Name = "repoBtnStockEntry";
            repoBtnStockEntry.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repoBtnStockEntry.ButtonClick += repoBtnStockEntry_ButtonClick;
            // 
            // gCOrderLineItem
            // 
            gCOrderLineItem.AppearanceCell.Options.UseTextOptions = true;
            gCOrderLineItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderLineItem.Caption = "Ürün Kodu";
            gCOrderLineItem.ColumnEdit = repoBtnItemSelect;
            gCOrderLineItem.FieldName = "itemcode";
            gCOrderLineItem.Name = "gCOrderLineItem";
            gCOrderLineItem.UnboundDataType = typeof(string);
            gCOrderLineItem.Visible = true;
            gCOrderLineItem.VisibleIndex = 1;
            gCOrderLineItem.Width = 359;
            // 
            // repoBtnItemSelect
            // 
            repoBtnItemSelect.AutoHeight = false;
            repoBtnItemSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            repoBtnItemSelect.Name = "repoBtnItemSelect";
            repoBtnItemSelect.ButtonClick += repoBtnItemSelect_ButtonClick;
            // 
            // gCOrderLineOrder
            // 
            gCOrderLineOrder.AppearanceCell.Options.UseTextOptions = true;
            gCOrderLineOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderLineOrder.Caption = "Sipariş Kodu";
            gCOrderLineOrder.ColumnEdit = repoLUOrder;
            gCOrderLineOrder.FieldName = "orderid";
            gCOrderLineOrder.Name = "gCOrderLineOrder";
            gCOrderLineOrder.OptionsColumn.AllowEdit = false;
            gCOrderLineOrder.Visible = true;
            gCOrderLineOrder.VisibleIndex = 2;
            gCOrderLineOrder.Width = 359;
            // 
            // repoLUOrder
            // 
            repoLUOrder.AutoHeight = false;
            repoLUOrder.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUOrder.DisplayMember = "ordercode";
            repoLUOrder.Name = "repoLUOrder";
            repoLUOrder.NullText = "";
            repoLUOrder.ValueMember = "id";
            // 
            // gCUnitPrice
            // 
            gCUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            gCUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCUnitPrice.Caption = "Birim Fiyat";
            gCUnitPrice.FieldName = "unitprice";
            gCUnitPrice.Name = "gCUnitPrice";
            gCUnitPrice.OptionsColumn.AllowEdit = false;
            gCUnitPrice.Visible = true;
            gCUnitPrice.VisibleIndex = 3;
            gCUnitPrice.Width = 359;
            // 
            // gCOrderLineItemTotalPrice
            // 
            gCOrderLineItemTotalPrice.AppearanceCell.Options.UseTextOptions = true;
            gCOrderLineItemTotalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderLineItemTotalPrice.Caption = "Toplam Ürün Fiyatı";
            gCOrderLineItemTotalPrice.FieldName = "itemtotalprice";
            gCOrderLineItemTotalPrice.Name = "gCOrderLineItemTotalPrice";
            gCOrderLineItemTotalPrice.Visible = true;
            gCOrderLineItemTotalPrice.VisibleIndex = 5;
            gCOrderLineItemTotalPrice.Width = 359;
            // 
            // gCOrderLineItemCount
            // 
            gCOrderLineItemCount.AppearanceCell.Options.UseTextOptions = true;
            gCOrderLineItemCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCOrderLineItemCount.Caption = "Ürün Miktarı";
            gCOrderLineItemCount.FieldName = "itemcount";
            gCOrderLineItemCount.Name = "gCOrderLineItemCount";
            gCOrderLineItemCount.Visible = true;
            gCOrderLineItemCount.VisibleIndex = 4;
            gCOrderLineItemCount.Width = 359;
            // 
            // gCDeleted
            // 
            gCDeleted.Caption = "Silindi Mi";
            gCDeleted.FieldName = "deleted";
            gCDeleted.Name = "gCDeleted";
            // 
            // gCDelete
            // 
            gCDelete.AppearanceCell.Options.UseTextOptions = true;
            gCDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gCDelete.Caption = "Sil";
            gCDelete.ColumnEdit = repoOrderlineDelete;
            gCDelete.Name = "gCDelete";
            gCDelete.Visible = true;
            gCDelete.VisibleIndex = 6;
            gCDelete.Width = 29;
            // 
            // repoOrderlineDelete
            // 
            repoOrderlineDelete.AutoHeight = false;
            editorButtonImageOptions2.ImageUri.Uri = "outlook%20inspired/delete";
            repoOrderlineDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repoOrderlineDelete.Name = "repoOrderlineDelete";
            repoOrderlineDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repoOrderlineDelete.ButtonClick += repoOrderlineDelete_ButtonClick;
            // 
            // panelControl3
            // 
            panelControl3.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl3.Appearance.Options.UseBackColor = true;
            panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl3.Controls.Add(txtEditOrderCode);
            panelControl3.Controls.Add(txtOrderTotalPrice);
            panelControl3.Controls.Add(labelControl16);
            panelControl3.Controls.Add(labelControl15);
            panelControl3.Controls.Add(labelControl11);
            panelControl3.Controls.Add(labelControl6);
            panelControl3.Controls.Add(LUEOrderStatus);
            panelControl3.Controls.Add(labelControl7);
            panelControl3.Controls.Add(LUEPaymentType);
            panelControl3.Controls.Add(labelControl8);
            panelControl3.Controls.Add(LUEOrderType);
            panelControl3.Controls.Add(labelControl9);
            panelControl3.Controls.Add(BtnEditTCKNVKN);
            panelControl3.Controls.Add(labelControl10);
            panelControl3.Controls.Add(txtEditOrderDate);
            panelControl3.Controls.Add(txtCompletedDate);
            panelControl3.Dock = DockStyle.Top;
            panelControl3.Location = new Point(2, 23);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new Size(1918, 130);
            panelControl3.TabIndex = 0;
            // 
            // txtEditOrderCode
            // 
            txtEditOrderCode.Enabled = false;
            txtEditOrderCode.Location = new Point(455, 24);
            txtEditOrderCode.Name = "txtEditOrderCode";
            txtEditOrderCode.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditOrderCode.Properties.Appearance.Options.UseFont = true;
            txtEditOrderCode.Size = new Size(160, 22);
            txtEditOrderCode.TabIndex = 29;
            // 
            // txtOrderTotalPrice
            // 
            txtOrderTotalPrice.Enabled = false;
            txtOrderTotalPrice.Location = new Point(455, 77);
            txtOrderTotalPrice.Name = "txtOrderTotalPrice";
            txtOrderTotalPrice.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtOrderTotalPrice.Properties.Appearance.Options.UseFont = true;
            txtOrderTotalPrice.Properties.NullText = "0,0";
            txtOrderTotalPrice.Size = new Size(160, 22);
            txtOrderTotalPrice.TabIndex = 27;
            // 
            // labelControl16
            // 
            labelControl16.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl16.Appearance.Options.UseFont = true;
            labelControl16.Location = new Point(344, 82);
            labelControl16.Name = "labelControl16";
            labelControl16.Size = new Size(78, 16);
            labelControl16.TabIndex = 26;
            labelControl16.Text = "Toplam Tutar";
            // 
            // labelControl15
            // 
            labelControl15.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl15.Appearance.Options.UseFont = true;
            labelControl15.Location = new Point(22, 80);
            labelControl15.Name = "labelControl15";
            labelControl15.Size = new Size(118, 16);
            labelControl15.TabIndex = 23;
            labelControl15.Text = "Sipariş Teslim Tarihi";
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new Point(1575, 31);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(124, 16);
            labelControl11.TabIndex = 21;
            labelControl11.Text = "Sipariş Verilme Tarihi";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(344, 27);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(71, 16);
            labelControl6.TabIndex = 19;
            labelControl6.Text = "Sipariş Kodu";
            // 
            // LUEOrderStatus
            // 
            LUEOrderStatus.Location = new Point(1388, 27);
            LUEOrderStatus.Name = "LUEOrderStatus";
            LUEOrderStatus.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUEOrderStatus.Properties.Appearance.Options.UseFont = true;
            LUEOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUEOrderStatus.Properties.DisplayMember = "name";
            LUEOrderStatus.Properties.NullText = "";
            LUEOrderStatus.Properties.ValueMember = "id";
            LUEOrderStatus.Size = new Size(160, 22);
            LUEOrderStatus.TabIndex = 18;
            LUEOrderStatus.EditValueChanged += LUEOrderStatus_EditValueChanged;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(1263, 29);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(88, 16);
            labelControl7.TabIndex = 17;
            labelControl7.Text = "Sipariş Durumu";
            // 
            // LUEPaymentType
            // 
            LUEPaymentType.Location = new Point(1073, 26);
            LUEPaymentType.Name = "LUEPaymentType";
            LUEPaymentType.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUEPaymentType.Properties.Appearance.Options.UseFont = true;
            LUEPaymentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUEPaymentType.Properties.DisplayMember = "name";
            LUEPaymentType.Properties.NullText = "";
            LUEPaymentType.Properties.ValueMember = "id";
            LUEPaymentType.Size = new Size(160, 22);
            LUEPaymentType.TabIndex = 16;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(950, 28);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(72, 16);
            labelControl8.TabIndex = 15;
            labelControl8.Text = "Ödeme Türü";
            // 
            // LUEOrderType
            // 
            LUEOrderType.Location = new Point(768, 26);
            LUEOrderType.Name = "LUEOrderType";
            LUEOrderType.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            LUEOrderType.Properties.Appearance.Options.UseFont = true;
            LUEOrderType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            LUEOrderType.Properties.DisplayMember = "name";
            LUEOrderType.Properties.NullText = "";
            LUEOrderType.Properties.ValueMember = "id";
            LUEOrderType.Size = new Size(160, 22);
            LUEOrderType.TabIndex = 14;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new Point(647, 28);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(70, 16);
            labelControl9.TabIndex = 13;
            labelControl9.Text = "Sipariş Türü";
            // 
            // BtnEditTCKNVKN
            // 
            BtnEditTCKNVKN.Location = new Point(158, 24);
            BtnEditTCKNVKN.Name = "BtnEditTCKNVKN";
            BtnEditTCKNVKN.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            BtnEditTCKNVKN.Properties.Appearance.Options.UseFont = true;
            BtnEditTCKNVKN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            BtnEditTCKNVKN.Size = new Size(160, 22);
            BtnEditTCKNVKN.TabIndex = 12;
            BtnEditTCKNVKN.ButtonClick += BtnEditTCKNVKN_ButtonClick;
            BtnEditTCKNVKN.EditValueChanged += BtnEditTCKNVKN_EditValueChanged;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new Font("Tahoma", 9.75F);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new Point(22, 27);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(105, 16);
            labelControl10.TabIndex = 11;
            labelControl10.Text = "Müşteri TCKN/VKN";
            // 
            // txtEditOrderDate
            // 
            txtEditOrderDate.EditValue = null;
            txtEditOrderDate.Location = new Point(1728, 27);
            txtEditOrderDate.Name = "txtEditOrderDate";
            txtEditOrderDate.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtEditOrderDate.Properties.Appearance.Options.UseFont = true;
            txtEditOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEditOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtEditOrderDate.Properties.DisplayFormat.FormatString = "";
            txtEditOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            txtEditOrderDate.Properties.EditFormat.FormatString = "";
            txtEditOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            txtEditOrderDate.Properties.MaskSettings.Set("mask", "d");
            txtEditOrderDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            txtEditOrderDate.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtEditOrderDate.Size = new Size(160, 22);
            txtEditOrderDate.TabIndex = 28;
            // 
            // txtCompletedDate
            // 
            txtCompletedDate.EditValue = null;
            txtCompletedDate.Location = new Point(158, 76);
            txtCompletedDate.Name = "txtCompletedDate";
            txtCompletedDate.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            txtCompletedDate.Properties.Appearance.Options.UseFont = true;
            txtCompletedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtCompletedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtCompletedDate.Properties.DisplayFormat.FormatString = "";
            txtCompletedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            txtCompletedDate.Properties.EditFormat.FormatString = "";
            txtCompletedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            txtCompletedDate.Properties.MaskSettings.Set("mask", "d");
            txtCompletedDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            txtCompletedDate.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtCompletedDate.Size = new Size(160, 22);
            txtCompletedDate.TabIndex = 25;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 680);
            Controls.Add(xtraTabControl1);
            Name = "OrderForm";
            Text = "Yönetim Sayfası";
            Load += OrderForm_Load;
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
            ((System.ComponentModel.ISupportInitialize)repoBtnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUTCKN).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUVKN).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUOrderType).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUOrderStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnOrderCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTCKNVKN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUOrderStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUPaymentType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUOrderType.Properties).EndInit();
            tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl5).EndInit();
            groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCOrderLineList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gVOrderLineList).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnStockEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnItemSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoOrderlineDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditOrderCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOrderTotalPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUEOrderStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUEPaymentType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LUEOrderType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnEditTCKNVKN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEditOrderDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEditOrderDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCompletedDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCompletedDate.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabList;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabPage tabDetail;
        private DevExpress.XtraGrid.GridControl GCList;
        private DevExpress.XtraGrid.Views.Grid.GridView GVList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnTCKNVKN;
        private DevExpress.XtraGrid.Columns.GridColumn gCId;
        private DevExpress.XtraGrid.Columns.GridColumn gCCustomerTCKN;
        private DevExpress.XtraGrid.Columns.GridColumn gCCustomerVKN;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderType;
        private DevExpress.XtraGrid.Columns.GridColumn gCPaymentId;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn gCCompletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderTotalPrice;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gCEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit LUEOrderStatus;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit LUEPaymentType;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit LUEOrderType;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ButtonEdit BtnEditTCKNVKN;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gCOrderLineList;
        private DevExpress.XtraGrid.Views.Grid.GridView gVOrderLineList;
        private DevExpress.XtraEditors.ButtonEdit btnOrderCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit LUOrderStatus;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit LUPaymentType;
        private DevExpress.XtraEditors.LookUpEdit LUOrderType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtOrderTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderLineId;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderLineItem;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderLineOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderLineItemTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderLineItemCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUOrder;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUTCKN;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUVKN;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUOrderType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUPayment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gCDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoOrderlineDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnItemSelect;
        private DevExpress.XtraGrid.Columns.GridColumn gCItemId;
        private DevExpress.XtraGrid.Columns.GridColumn gCDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn gCUnitPrice;
        private DevExpress.XtraEditors.DateEdit txtEditOrderDate;
        private DevExpress.XtraEditors.DateEdit txtCompletedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gCOrderDeleted;
        private DevExpress.XtraEditors.TextEdit txtEditOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn gCStockEntry;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnStockEntry;
    }
}