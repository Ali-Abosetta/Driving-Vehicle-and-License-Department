namespace DrivingVehicleLicenseDepartment.Forms.Licenses.Applications
{
    partial class frmRenewLicense
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
            this.lblShowLicenseInfo = new Krypton.Toolkit.KryptonLinkLabel();
            this.lblShowLicenseHistory = new Krypton.Toolkit.KryptonLinkLabel();
            this.btnRenew = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlRenewLicenseWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlRenewLicenseWithFilter();
            this.SuspendLayout();
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(509, 789);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(150, 25);
            this.lblShowLicenseInfo.TabIndex = 24;
            this.lblShowLicenseInfo.Values.Text = "Show license information";
            this.lblShowLicenseInfo.LinkClicked += new System.EventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(509, 816);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(164, 25);
            this.lblShowLicenseHistory.TabIndex = 25;
            this.lblShowLicenseHistory.Values.Text = "Show driver licenses history";
            this.lblShowLicenseHistory.LinkClicked += new System.EventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Location = new System.Drawing.Point(58, 789);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(216, 52);
            this.btnRenew.TabIndex = 22;
            this.btnRenew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRenew.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Renew_Driving_License_32;
            this.btnRenew.Values.Text = "Renew";
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(287, 789);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 23;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(264, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(239, 35);
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Renew license application";
            // 
            // ctrlRenewLicenseWithFilter1
            // 
            this.ctrlRenewLicenseWithFilter1.Application = null;
            this.ctrlRenewLicenseWithFilter1.Location = new System.Drawing.Point(7, 48);
            this.ctrlRenewLicenseWithFilter1.Name = "ctrlRenewLicenseWithFilter1";
            this.ctrlRenewLicenseWithFilter1.OldLicense = null;
            this.ctrlRenewLicenseWithFilter1.Size = new System.Drawing.Size(829, 738);
            this.ctrlRenewLicenseWithFilter1.TabIndex = 0;
            this.ctrlRenewLicenseWithFilter1.OnLicenseSelected += new System.EventHandler(this.ctrlRenewLicenseWithFilter1_OnLicenseSelected);
            this.ctrlRenewLicenseWithFilter1.OnLicenseNotFound += new System.EventHandler(this.ctrlRenewLicenseWithFilter1_OnLicenseNotFound);
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 853);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlRenewLicenseWithFilter1);
            this.Name = "frmRenewLicense";
            this.Text = "frmRenewLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ctrlRenewLicenseWithFilter ctrlRenewLicenseWithFilter1;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseInfo;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseHistory;
        private Krypton.Toolkit.KryptonButton btnRenew;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}