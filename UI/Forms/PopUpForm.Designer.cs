namespace UI.Forms
{
    partial class PopUpForm<T>
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            gCList = new DevExpress.XtraGrid.GridControl();
            gVList = new DevExpress.XtraGrid.Views.Grid.GridView();
            repoBtnItemSelect = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            repoLUItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)gCList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gVList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnItemSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repoLUItem).BeginInit();
            SuspendLayout();
            // 
            // gCList
            // 
            gCList.Dock = DockStyle.Fill;
            gCList.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gCList.Location = new Point(0, 0);
            gCList.MainView = gVList;
            gCList.Margin = new Padding(3, 2, 3, 2);
            gCList.Name = "gCList";
            gCList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repoBtnItemSelect, repoLUItem });
            gCList.Size = new Size(1161, 589);
            gCList.TabIndex = 0;
            gCList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gVList });
            // 
            // gVList
            // 
            gVList.DetailHeight = 262;
            gVList.GridControl = gCList;
            gVList.Name = "gVList";
            gVList.OptionsBehavior.Editable = false;
            gVList.OptionsEditForm.PopupEditFormWidth = 700;
            gVList.OptionsView.ShowGroupPanel = false;
            gVList.DoubleClick += gVList_DoubleClick;
            // 
            // repoBtnItemSelect
            // 
            repoBtnItemSelect.AutoHeight = false;
            editorButtonImageOptions1.ImageUri.Uri = "diagramicons/selecttool_pantool";
            repoBtnItemSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repoBtnItemSelect.Name = "repoBtnItemSelect";
            repoBtnItemSelect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repoLUItem
            // 
            repoLUItem.AutoHeight = false;
            repoLUItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repoLUItem.DisplayMember = "name";
            repoLUItem.Name = "repoLUItem";
            repoLUItem.ValueMember = "id";
            // 
            // PopUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 589);
            Controls.Add(gCList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PopUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUpForm";
            Load += PopUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)gCList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gVList).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoBtnItemSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)repoLUItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gCList;
        private DevExpress.XtraGrid.Views.Grid.GridView gVList;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnItemSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLUItem;
    }
}