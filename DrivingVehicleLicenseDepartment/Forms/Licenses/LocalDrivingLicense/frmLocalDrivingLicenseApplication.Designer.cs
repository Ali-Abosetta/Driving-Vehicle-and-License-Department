namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
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
            this.cmsLocalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUserDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SechduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLocalLicenseApplications = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pbMainUserPhoto = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            this.cmsLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(395, 365);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 21);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.Search);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1304, 342);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(151, 44);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNew.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.New_Application_32;
            this.btnAddNew.Values.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 359);
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
            this.cmbFilter.Size = new System.Drawing.Size(248, 20);
            this.cmbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFilter.TabIndex = 22;
            this.cmbFilter.Text = "cmbLocalLicenseApplications";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // cmsLocalLicenses
            // 
            this.cmsLocalLicenses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsLocalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.EditApplicationToolStripMenuItem,
            this.DeleteApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.CancelToolStripMenuItem,
            this.toolStripSeparator2,
            this.SechduleTestsToolStripMenuItem,
            this.IssueLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLocalLicenses.Name = "cmsPeople";
            this.cmsLocalLicenses.Size = new System.Drawing.Size(262, 348);
            // 
            // showUserDetailsToolStripMenuItem
            // 
            this.showUserDetailsToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.PersonDetails_32;
            this.showUserDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            this.showUserDetailsToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showUserDetailsToolStripMenuItem.Text = "Show user details";
            this.showUserDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showUserDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowApplicatoinCard);
            // 
            // EditApplicationToolStripMenuItem
            // 
            this.EditApplicationToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.edit_32;
            this.EditApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            this.EditApplicationToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.EditApplicationToolStripMenuItem.Text = "Edit application";
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            this.DeleteApplicationToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Delete_32_2;
            this.DeleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            this.DeleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.DeleteApplicationToolStripMenuItem.Text = "Delete application";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Delete_32;
            this.CancelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.CancelToolStripMenuItem.Text = "Cancel application";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // SechduleTestsToolStripMenuItem
            // 
            this.SechduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.SechduleTestsToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Schedule_Test_32;
            this.SechduleTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SechduleTestsToolStripMenuItem.Name = "SechduleTestsToolStripMenuItem";
            this.SechduleTestsToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.SechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Vision_Test_Schdule;
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Written_Test_32_Sechdule;
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // IssueLicenseToolStripMenuItem
            // 
            this.IssueLicenseToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.IssueDrivingLicense_32;
            this.IssueLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueLicenseToolStripMenuItem.Name = "IssueLicenseToolStripMenuItem";
            this.IssueLicenseToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.IssueLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // dgvLocalLicenseApplications
            // 
            this.dgvLocalLicenseApplications.AllowUserToAddRows = false;
            this.dgvLocalLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseApplications.AllowUserToOrderColumns = true;
            this.dgvLocalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenseApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApplications.ContextMenuStrip = this.cmsLocalLicenses;
            this.dgvLocalLicenseApplications.Location = new System.Drawing.Point(12, 415);
            this.dgvLocalLicenseApplications.Name = "dgvLocalLicenseApplications";
            this.dgvLocalLicenseApplications.Palette = this.PaletteDGVs;
            this.dgvLocalLicenseApplications.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLocalLicenseApplications.ReadOnly = true;
            this.dgvLocalLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenseApplications.Size = new System.Drawing.Size(1443, 230);
            this.dgvLocalLicenseApplications.TabIndex = 19;
            this.dgvLocalLicenseApplications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowApplicatoinCard);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(589, 288);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(424, 35);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Local Driving License Applications";
            // 
            // pbMainUserPhoto
            // 
            this.pbMainUserPhoto.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Applications;
            this.pbMainUserPhoto.Location = new System.Drawing.Point(657, 32);
            this.pbMainUserPhoto.Name = "pbMainUserPhoto";
            this.pbMainUserPhoto.Size = new System.Drawing.Size(280, 250);
            this.pbMainUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainUserPhoto.TabIndex = 17;
            this.pbMainUserPhoto.TabStop = false;
            // 
            // frmLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 677);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.pbMainUserPhoto);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dgvLocalLicenseApplications);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "frmLocalDrivingLicenseApplication";
            this.Text = "frmLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            this.cmsLocalLicenses.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem IssueLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SechduleTestsToolStripMenuItem;
        private Krypton.Toolkit.KryptonComboBox cmbFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showUserDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenses;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private Krypton.Toolkit.KryptonDataGridView dgvLocalLicenseApplications;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}