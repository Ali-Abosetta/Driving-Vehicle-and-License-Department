namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    partial class frmAddInternationalLicense
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
            this.btnIssue = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.lblShowLicenseHistory = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblShowLicenseInfo = new Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlLicenseApplicationWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlLicenseApplicationWithFilter();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new System.Drawing.Point(186, 768);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(216, 52);
            this.btnIssue.TabIndex = 19;
            this.btnIssue.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIssue.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssue.Values.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 768);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 20;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(168, 826);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(164, 25);
            this.lblShowLicenseHistory.TabIndex = 21;
            this.lblShowLicenseHistory.Values.Text = "Show driver licenses history";
            this.lblShowLicenseHistory.LinkClicked += new System.EventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(443, 826);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(150, 25);
            this.lblShowLicenseInfo.TabIndex = 21;
            this.lblShowLicenseInfo.Values.Text = "Show license information";
            this.lblShowLicenseInfo.LinkClicked += new System.EventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(299, 36);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(239, 35);
            this.kryptonLabel1.TabIndex = 23;
            this.kryptonLabel1.Values.Text = "New International License";
            // 
            // ctrlLicenseApplicationWithFilter1
            // 
            this.ctrlLicenseApplicationWithFilter1.Application = null;
            this.ctrlLicenseApplicationWithFilter1.License = null;
            this.ctrlLicenseApplicationWithFilter1.Location = new System.Drawing.Point(8, 92);
            this.ctrlLicenseApplicationWithFilter1.Name = "ctrlLicenseApplicationWithFilter1";
            this.ctrlLicenseApplicationWithFilter1.Size = new System.Drawing.Size(829, 650);
            this.ctrlLicenseApplicationWithFilter1.TabIndex = 22;
            this.ctrlLicenseApplicationWithFilter1.OnLicenseSelected += new System.EventHandler(this.ctrlLicenseApplicationWithFilter1_OnLicenseSelected_1);
            // 
            // frmAddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(843, 863);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.ctrlLicenseApplicationWithFilter1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddInternationalLicense";
            this.Text = "frmAddInternationalLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnIssue;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseHistory;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseInfo;
        private CustomControls.ctrlLicenseApplicationWithFilter ctrlLicenseApplicationWithFilter1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}