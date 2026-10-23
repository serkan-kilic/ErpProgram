namespace UI
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            btnSaveUpdate = new DevExpress.XtraEditors.SimpleButton();
            lblPageName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(btnClose);
            panelControl1.Controls.Add(btnDelete);
            panelControl1.Controls.Add(btnClear);
            panelControl1.Controls.Add(btnSaveUpdate);
            panelControl1.Controls.Add(lblPageName);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(800, 64);
            panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Appearance.BackColor = Color.Gray;
            btnClose.Appearance.BorderColor = Color.Red;
            btnClose.Appearance.ForeColor = Color.Transparent;
            btnClose.Appearance.Options.UseBackColor = true;
            btnClose.Appearance.Options.UseBorderColor = true;
            btnClose.Appearance.Options.UseForeColor = true;
            btnClose.AppearanceHovered.BackColor = Color.Gray;
            btnClose.AppearanceHovered.BorderColor = Color.Gray;
            btnClose.AppearanceHovered.Options.UseBackColor = true;
            btnClose.AppearanceHovered.Options.UseBorderColor = true;
            btnClose.Dock = DockStyle.Right;
            btnClose.ImageOptions.Image = (Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnClose.Location = new Point(628, 0);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClose.Size = new Size(43, 64);
            btnClose.TabIndex = 4;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Appearance.BackColor = Color.Gray;
            btnDelete.Appearance.BorderColor = Color.Red;
            btnDelete.Appearance.ForeColor = Color.Transparent;
            btnDelete.Appearance.Options.UseBackColor = true;
            btnDelete.Appearance.Options.UseBorderColor = true;
            btnDelete.Appearance.Options.UseForeColor = true;
            btnDelete.AppearanceHovered.BackColor = Color.Gray;
            btnDelete.AppearanceHovered.BorderColor = Color.Gray;
            btnDelete.AppearanceHovered.Options.UseBackColor = true;
            btnDelete.AppearanceHovered.Options.UseBorderColor = true;
            btnDelete.Dock = DockStyle.Right;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnDelete.Location = new Point(671, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnDelete.Size = new Size(43, 64);
            btnDelete.TabIndex = 3;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Appearance.BackColor = Color.Gray;
            btnClear.Appearance.BorderColor = Color.Red;
            btnClear.Appearance.ForeColor = Color.Transparent;
            btnClear.Appearance.Options.UseBackColor = true;
            btnClear.Appearance.Options.UseBorderColor = true;
            btnClear.Appearance.Options.UseForeColor = true;
            btnClear.AppearanceHovered.BackColor = Color.Gray;
            btnClear.AppearanceHovered.BorderColor = Color.Gray;
            btnClear.AppearanceHovered.Options.UseBackColor = true;
            btnClear.AppearanceHovered.Options.UseBorderColor = true;
            btnClear.Dock = DockStyle.Right;
            btnClear.ImageOptions.Image = (Image)resources.GetObject("btnClear.ImageOptions.Image");
            btnClear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnClear.Location = new Point(714, 0);
            btnClear.Name = "btnClear";
            btnClear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnClear.Size = new Size(43, 64);
            btnClear.TabIndex = 2;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Appearance.BackColor = Color.Gray;
            btnSaveUpdate.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSaveUpdate.Appearance.ForeColor = Color.Transparent;
            btnSaveUpdate.Appearance.Options.UseBackColor = true;
            btnSaveUpdate.Appearance.Options.UseBorderColor = true;
            btnSaveUpdate.Appearance.Options.UseForeColor = true;
            btnSaveUpdate.AppearanceHovered.BackColor = Color.Gray;
            btnSaveUpdate.AppearanceHovered.BorderColor = Color.Gray;
            btnSaveUpdate.AppearanceHovered.Options.UseBackColor = true;
            btnSaveUpdate.AppearanceHovered.Options.UseBorderColor = true;
            btnSaveUpdate.Dock = DockStyle.Right;
            btnSaveUpdate.ImageOptions.Image = (Image)resources.GetObject("btnSaveUpdate.ImageOptions.Image");
            btnSaveUpdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnSaveUpdate.Location = new Point(757, 0);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnSaveUpdate.Size = new Size(43, 64);
            btnSaveUpdate.TabIndex = 1;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // lblPageName
            // 
            lblPageName.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPageName.Appearance.Options.UseFont = true;
            lblPageName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            lblPageName.ImageOptions.Alignment = ContentAlignment.MiddleLeft;
            lblPageName.Location = new Point(12, 17);
            lblPageName.Name = "lblPageName";
            lblPageName.Size = new Size(129, 23);
            lblPageName.TabIndex = 0;
            lblPageName.Text = "labelControl1";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelControl1);
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseForm";
            WindowState = FormWindowState.Maximized;
            Load += BaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSaveUpdate;
        private DevExpress.XtraEditors.LabelControl lblPageName;
    }
}