namespace DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses
{
    partial class frmReleaseDetainedLicense
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblShowLicenseInfo = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblShowLicenseHistory = new Krypton.Toolkit.KryptonLinkLabel();
            this.btnRelease = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.ctrlReleaseLicenseWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlReleaseLicenseWithFilter();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(298, 36);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(313, 35);
            this.kryptonLabel1.TabIndex = 44;
            this.kryptonLabel1.Values.Text = "Release detained license";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(553, 743);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(234, 27);
            this.lblShowLicenseInfo.TabIndex = 42;
            this.lblShowLicenseInfo.Values.Text = "Show license information";
            this.lblShowLicenseInfo.LinkClicked += new System.EventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(553, 770);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(256, 27);
            this.lblShowLicenseHistory.TabIndex = 43;
            this.lblShowLicenseHistory.Values.Text = "Show driver licenses history";
            this.lblShowLicenseHistory.LinkClicked += new System.EventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // btnRelease
            // 
            this.btnRelease.Enabled = false;
            this.btnRelease.Location = new System.Drawing.Point(102, 743);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(216, 52);
            this.btnRelease.TabIndex = 40;
            this.btnRelease.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRelease.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.Values.Text = "Release";
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 743);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 41;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlReleaseLicenseWithFilter1
            // 
            this.ctrlReleaseLicenseWithFilter1.detainedLicenses = null;
            this.ctrlReleaseLicenseWithFilter1.License = null;
            this.ctrlReleaseLicenseWithFilter1.Location = new System.Drawing.Point(7, 77);
            this.ctrlReleaseLicenseWithFilter1.Name = "ctrlReleaseLicenseWithFilter1";
            this.ctrlReleaseLicenseWithFilter1.Size = new System.Drawing.Size(829, 656);
            this.ctrlReleaseLicenseWithFilter1.TabIndex = 45;
            this.ctrlReleaseLicenseWithFilter1.OnLicenseSelected += new System.EventHandler(this.ctrlReleaseLicenseWithFilter1_OnLicenseSelected);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 806);
            this.Controls.Add(this.ctrlReleaseLicenseWithFilter1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseInfo;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseHistory;
        private Krypton.Toolkit.KryptonButton btnRelease;
        private Krypton.Toolkit.KryptonButton btnClose;
        private CustomControls.ctrlReleaseLicenseWithFilter ctrlReleaseLicenseWithFilter1;
    }
}