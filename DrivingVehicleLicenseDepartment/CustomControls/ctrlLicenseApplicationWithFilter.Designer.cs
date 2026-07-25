namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlLicenseApplicationWithFilter
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
            this.ctrlDriverLicenseCard1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlDriverLicenseCard();
            this.ctrlInternationLicenseApplicationBasicInfo1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlInternationLicenseApplicationBasicInfo();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(118, 3);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSearch);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtSearch);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(598, 78);
            this.kryptonGroupBox1.TabIndex = 2;
            this.kryptonGroupBox1.Values.Heading = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(473, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.SearchPerson;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(109, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(358, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "License ID:";
            // 
            // ctrlDriverLicenseCard1
            // 
            this.ctrlDriverLicenseCard1.License = null;
            this.ctrlDriverLicenseCard1.Location = new System.Drawing.Point(3, 83);
            this.ctrlDriverLicenseCard1.Name = "ctrlDriverLicenseCard1";
            this.ctrlDriverLicenseCard1.Size = new System.Drawing.Size(820, 310);
            this.ctrlDriverLicenseCard1.TabIndex = 0;
            // 
            // ctrlInternationLicenseApplicationBasicInfo1
            // 
            this.ctrlInternationLicenseApplicationBasicInfo1.Application = null;
            this.ctrlInternationLicenseApplicationBasicInfo1.InternationalLicense = null;
            this.ctrlInternationLicenseApplicationBasicInfo1.Location = new System.Drawing.Point(3, 399);
            this.ctrlInternationLicenseApplicationBasicInfo1.Name = "ctrlInternationLicenseApplicationBasicInfo1";
            this.ctrlInternationLicenseApplicationBasicInfo1.Size = new System.Drawing.Size(820, 230);
            this.ctrlInternationLicenseApplicationBasicInfo1.TabIndex = 3;
            // 
            // ctrlLicenseApplicationWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlInternationLicenseApplicationBasicInfo1);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.ctrlDriverLicenseCard1);
            this.Name = "ctrlLicenseApplicationWithFilter";
            this.Size = new System.Drawing.Size(829, 637);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseCard ctrlDriverLicenseCard1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ctrlInternationLicenseApplicationBasicInfo ctrlInternationLicenseApplicationBasicInfo1;
    }
}
