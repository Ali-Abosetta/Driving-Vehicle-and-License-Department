namespace DrivingVehicleLicenseDepartment.Forms.Licenses
{
    partial class frmLicenseHistory
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
            BLL.People people1 = new BLL.People();
            BLL.Countries countries1 = new BLL.Countries();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new Krypton.Toolkit.KryptonDataGridView();
            this.PaletteDGVs = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.ctrlPersonCardEditable1 = new DrivingVehicleLicenseDepartment.Forms.People.Controls.ctrlPersonCardEditable();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 458);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.tabControl1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1248, 232);
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLocalLicenses);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1236, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AllowUserToOrderColumns = true;
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.Palette = this.PaletteDGVs;
            this.dgvLocalLicenses.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(1230, 169);
            this.dgvLocalLicenses.TabIndex = 24;
            // 
            // PaletteDGVs
            // 
            this.PaletteDGVs.BaseFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaletteDGVs.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvInternationalLicenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1236, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.Palette = this.PaletteDGVs;
            this.dgvInternationalLicenses.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1230, 178);
            this.dgvInternationalLicenses.TabIndex = 25;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.PersonLicenseHistory_512;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(43, 75);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(314, 377);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 2;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // ctrlPersonCardEditable1
            // 
            this.ctrlPersonCardEditable1.Enabled = false;
            this.ctrlPersonCardEditable1.Location = new System.Drawing.Point(379, 75);
            this.ctrlPersonCardEditable1.Name = "ctrlPersonCardEditable1";
            people1.Address = "";
            countries1.CountryID = 100;
            countries1.CountryName = "Libya";
            people1.CountryInfo = countries1;
            people1.DateOfBirth = new System.DateTime(2008, 7, 25, 14, 14, 56, 779);
            people1.Email = "";
            people1.FirstName = "";
            people1.Gendor = 0;
            people1.ImagePath = null;
            people1.LastName = "";
            people1.NationalityCountryID = 100;
            people1.NationalNo = "";
            people1.PersonID = -1;
            people1.Phone = "";
            people1.SecondName = "";
            people1.ThirdName = "";
            this.ctrlPersonCardEditable1.Person = people1;
            this.ctrlPersonCardEditable1.Size = new System.Drawing.Size(881, 377);
            this.ctrlPersonCardEditable1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(489, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(211, 35);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Licenses History";
            // 
            // frmLicenseHistory
            // 
            this.ClientSize = new System.Drawing.Size(1272, 702);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonPictureBox1);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.ctrlPersonCardEditable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicenseHistory";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrivingVehicleLicenseDepartment.Forms.People.Controls.ctrlPersonCardEditable ctrlPersonCardEditable1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public Krypton.Toolkit.KryptonCustomPaletteBase PaletteDGVs;
        private Krypton.Toolkit.KryptonDataGridView dgvLocalLicenses;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDataGridView dgvInternationalLicenses;
    }
}