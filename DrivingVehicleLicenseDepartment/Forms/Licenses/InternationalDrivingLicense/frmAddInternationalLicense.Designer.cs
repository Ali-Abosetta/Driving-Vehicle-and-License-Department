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
            this.ctrlLicenseApplicationWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlLicenseApplicationWithFilter();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(6, 641);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(216, 52);
            this.btnIssue.TabIndex = 19;
            this.btnIssue.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIssue.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssue.Values.Text = "Issue";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(230, 641);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 20;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(472, 669);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(164, 25);
            this.lblShowLicenseHistory.TabIndex = 21;
            this.lblShowLicenseHistory.Values.Text = "Show driver licenses history";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(642, 669);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(150, 25);
            this.lblShowLicenseInfo.TabIndex = 21;
            this.lblShowLicenseInfo.Values.Text = "Show license information";
            // 
            // ctrlLicenseApplicationWithFilter1
            // 
            this.ctrlLicenseApplicationWithFilter1.Location = new System.Drawing.Point(5, 5);
            this.ctrlLicenseApplicationWithFilter1.Name = "ctrlLicenseApplicationWithFilter1";
            this.ctrlLicenseApplicationWithFilter1.Size = new System.Drawing.Size(829, 630);
            this.ctrlLicenseApplicationWithFilter1.TabIndex = 22;
            // 
            // frmAddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 701);
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
    }
}