namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlReplacementLicenseWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.rbDamaged = new Krypton.Toolkit.KryptonRadioButton();
            this.rbLost = new Krypton.Toolkit.KryptonRadioButton();
            this.ctrlApplicationReplacementLicenseInfo1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlApplicationReplacementLicenseInfo();
            this.ctrlDriverLicenseCard1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlDriverLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(4, 2);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSearch);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtSearch);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(612, 93);
            this.kryptonGroupBox1.TabIndex = 7;
            this.kryptonGroupBox1.Values.Heading = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(520, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 51);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.SearchPerson;
            this.btnSearch.Values.Text = "";
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(358, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(9, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "License ID:";
            // 
            // rbDamaged
            // 
            this.rbDamaged.Checked = true;
            this.rbDamaged.Location = new System.Drawing.Point(639, 29);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(115, 25);
            this.rbDamaged.TabIndex = 9;
            this.rbDamaged.Values.Text = "Damaged license";
            // 
            // rbLost
            // 
            this.rbLost.Location = new System.Drawing.Point(639, 60);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(139, 25);
            this.rbLost.TabIndex = 9;
            this.rbLost.Values.Text = "Lost license";
            // 
            // ctrlApplicationReplacementLicenseInfo1
            // 
            this.ctrlApplicationReplacementLicenseInfo1.Location = new System.Drawing.Point(4, 417);
            this.ctrlApplicationReplacementLicenseInfo1.Name = "ctrlApplicationReplacementLicenseInfo1";
            this.ctrlApplicationReplacementLicenseInfo1.NewLicense = null;
            this.ctrlApplicationReplacementLicenseInfo1.OldLicense = null;
            this.ctrlApplicationReplacementLicenseInfo1.Size = new System.Drawing.Size(820, 188);
            this.ctrlApplicationReplacementLicenseInfo1.TabIndex = 8;
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.License = null;
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(4, 101);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(820, 310);
            this.ctrlDriverLicenseCard1.TabIndex = 6;
            // 
            // ctrlReplacementLicenseWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbLost);
            this.Controls.Add(this.rbDamaged);
            this.Controls.Add(this.ctrlApplicationReplacementLicenseInfo1);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.Name = "ctrlReplacementLicenseWithFilter";
            this.Size = new System.Drawing.Size(829, 613);
            this.Click += new System.EventHandler(this.Search);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        private ctrlApplicationReplacementLicenseInfo ctrlApplicationReplacementLicenseInfo1;
        private Krypton.Toolkit.KryptonRadioButton rbLost;
        public Krypton.Toolkit.KryptonRadioButton rbDamaged;
    }
}
