namespace DrivingVehicleLicenseDepartment.Forms.Licenses.Applications
{
    partial class frmReplaceLicense
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
            this.btnReplace = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.ctrlReplacementLicenseWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlReplacementLicenseWithFilter();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(295, 28);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(249, 35);
            this.kryptonLabel1.TabIndex = 32;
            this.kryptonLabel1.Values.Text = "Replace license application";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(509, 686);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(150, 25);
            this.lblShowLicenseInfo.TabIndex = 30;
            this.lblShowLicenseInfo.Values.Text = "Show license information";
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(509, 713);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(164, 25);
            this.lblShowLicenseHistory.TabIndex = 31;
            this.lblShowLicenseHistory.Values.Text = "Show driver licenses history";
            this.lblShowLicenseHistory.LinkClicked += new System.EventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(58, 686);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(216, 52);
            this.btnReplace.TabIndex = 28;
            this.btnReplace.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReplace.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.IssueDrivingLicense_32;
            this.btnReplace.Values.Text = "Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(287, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 29;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlReplacementLicenseWithFilter1
            // 
            this.ctrlReplacementLicenseWithFilter1.Application = null;
            this.ctrlReplacementLicenseWithFilter1.Location = new System.Drawing.Point(2, 66);
            this.ctrlReplacementLicenseWithFilter1.Name = "ctrlReplacementLicenseWithFilter1";
            this.ctrlReplacementLicenseWithFilter1.OldLicense = null;
            this.ctrlReplacementLicenseWithFilter1.Size = new System.Drawing.Size(829, 613);
            this.ctrlReplacementLicenseWithFilter1.TabIndex = 33;
            this.ctrlReplacementLicenseWithFilter1.OnLicenseSelected += new System.EventHandler(this.ctrlReplacementLicenseWithFilter1_OnLicenseSelected);
            // 
            // frmReplaceLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(843, 751);
            this.Controls.Add(this.ctrlReplacementLicenseWithFilter1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReplaceLicense";
            this.Text = "frmReplaceLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseInfo;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseHistory;
        private Krypton.Toolkit.KryptonButton btnReplace;
        private Krypton.Toolkit.KryptonButton btnClose;
        private CustomControls.ctrlReplacementLicenseWithFilter ctrlReplacementLicenseWithFilter1;
    }
}