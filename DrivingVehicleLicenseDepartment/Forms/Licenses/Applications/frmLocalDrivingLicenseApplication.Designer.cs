namespace DrivingVehicleLicenseDepartment.Forms.Licenses.Applications
{
    partial class frmLocalDrivingLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.btnAddNew = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.PaletteDGVs = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.cmbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvLocalLicenseApplications = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pbMainUserPhoto = new Krypton.Toolkit.KryptonPictureBox();
            this.showUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(350, 365);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(271, 30);
            this.txtSearch.TabIndex = 23;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1077, 351);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(151, 44);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNew.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Add_New_User_32;
            this.btnAddNew.Values.Text = "Add New";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 368);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 27);
            this.kryptonLabel2.TabIndex = 20;
            this.kryptonLabel2.Values.Text = "Filter:";
            // 
            // PaletteDGVs
            // 
            this.PaletteDGVs.BaseFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaletteDGVs.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Location = new System.Drawing.Point(141, 366);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(190, 29);
            this.cmbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFilter.TabIndex = 22;
            this.cmbFilter.Text = "cmbLocalLicenseApplications";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // cmsUsers
            // 
            this.cmsUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsUsers.Name = "cmsPeople";
            this.cmsUsers.Size = new System.Drawing.Size(182, 244);
            // 
            // dgvLocalLicenseApplications
            // 
            this.dgvLocalLicenseApplications.AllowUserToAddRows = false;
            this.dgvLocalLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseApplications.AllowUserToOrderColumns = true;
            this.dgvLocalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApplications.ContextMenuStrip = this.cmsUsers;
            this.dgvLocalLicenseApplications.Location = new System.Drawing.Point(12, 415);
            this.dgvLocalLicenseApplications.Name = "dgvLocalLicenseApplications";
            this.dgvLocalLicenseApplications.Palette = this.PaletteDGVs;
            this.dgvLocalLicenseApplications.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLocalLicenseApplications.ReadOnly = true;
            this.dgvLocalLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenseApplications.Size = new System.Drawing.Size(1216, 230);
            this.dgvLocalLicenseApplications.TabIndex = 19;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(401, 288);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(424, 35);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Local Driving License Applications";
            // 
            // pbMainUserPhoto
            // 
            this.pbMainUserPhoto.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Applications;
            this.pbMainUserPhoto.Location = new System.Drawing.Point(469, 32);
            this.pbMainUserPhoto.Name = "pbMainUserPhoto";
            this.pbMainUserPhoto.Size = new System.Drawing.Size(280, 250);
            this.pbMainUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainUserPhoto.TabIndex = 17;
            this.pbMainUserPhoto.TabStop = false;
            // 
            // showUserDetailsToolStripMenuItem
            // 
            this.showUserDetailsToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.PersonDetails_32;
            this.showUserDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            this.showUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.showUserDetailsToolStripMenuItem.Text = "Show user details";
            this.showUserDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Add_New_User_321;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.addNewPersonToolStripMenuItem.Text = "Add new user";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Edit_User_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Delete_User_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // frmLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 677);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.pbMainUserPhoto);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dgvLocalLicenseApplications);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "frmLocalDrivingLicenseApplication";
            this.Text = "frmLocalDrivingLicenseApplication";
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnAddNew;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPictureBox pbMainUserPhoto;
        public Krypton.Toolkit.KryptonCustomPaletteBase PaletteDGVs;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private Krypton.Toolkit.KryptonComboBox cmbFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Krypton.Toolkit.KryptonDataGridView dgvLocalLicenseApplications;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}