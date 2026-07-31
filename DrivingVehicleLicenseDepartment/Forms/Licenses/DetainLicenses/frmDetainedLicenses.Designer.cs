namespace DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses
{
    partial class frmDetainedLicenses
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
            this.btnDetain = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.PaletteDGVs = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.cmbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.cmsDetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLicenses = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnRelease = new Krypton.Toolkit.KryptonButton();
            this.pbMainUserPhoto = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            this.cmsDetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).BeginInit();
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
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(1077, 351);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(151, 44);
            this.btnDetain.TabIndex = 21;
            this.btnDetain.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDetain.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Detain_32;
            this.btnDetain.Values.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
            this.cmbFilter.Text = "cmbUsersFields";
            // 
            // cmsDetainedLicenses
            // 
            this.cmsDetainedLicenses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsDetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem});
            this.cmsDetainedLicenses.Name = "cmsPeople";
            this.cmsDetainedLicenses.Size = new System.Drawing.Size(237, 162);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show person details";
            this.showPersonDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.License_View_32;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.addNewPersonToolStripMenuItem.Text = "Show license details";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.PersonLicenseHistory_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.editToolStripMenuItem.Text = "Show person license history";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Release_Detained_License_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.deleteToolStripMenuItem.Text = "Release detained license";
            // 
            // dgvLicenses
            // 
            this.dgvLicenses.AllowUserToAddRows = false;
            this.dgvLicenses.AllowUserToDeleteRows = false;
            this.dgvLicenses.AllowUserToOrderColumns = true;
            this.dgvLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenses.ContextMenuStrip = this.cmsDetainedLicenses;
            this.dgvLicenses.Location = new System.Drawing.Point(12, 415);
            this.dgvLicenses.Name = "dgvLicenses";
            this.dgvLicenses.Palette = this.PaletteDGVs;
            this.dgvLicenses.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLicenses.ReadOnly = true;
            this.dgvLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLicenses.Size = new System.Drawing.Size(1216, 230);
            this.dgvLicenses.TabIndex = 19;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(514, 288);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(292, 35);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Manage detain licenses";
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(920, 351);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(151, 44);
            this.btnRelease.TabIndex = 21;
            this.btnRelease.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRelease.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.Values.Text = "Release";
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // pbMainUserPhoto
            // 
            this.pbMainUserPhoto.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Detain_512;
            this.pbMainUserPhoto.Location = new System.Drawing.Point(469, 32);
            this.pbMainUserPhoto.Name = "pbMainUserPhoto";
            this.pbMainUserPhoto.Size = new System.Drawing.Size(280, 250);
            this.pbMainUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainUserPhoto.TabIndex = 17;
            this.pbMainUserPhoto.TabStop = false;
            // 
            // frmDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 677);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.pbMainUserPhoto);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dgvLicenses);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "frmDetainedLicenses";
            this.Text = "frmDetainedLicenses";
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            this.cmsDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonButton btnDetain;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonPictureBox pbMainUserPhoto;
        public Krypton.Toolkit.KryptonCustomPaletteBase PaletteDGVs;
        private Krypton.Toolkit.KryptonComboBox cmbFilter;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Krypton.Toolkit.KryptonDataGridView dgvLicenses;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnRelease;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}