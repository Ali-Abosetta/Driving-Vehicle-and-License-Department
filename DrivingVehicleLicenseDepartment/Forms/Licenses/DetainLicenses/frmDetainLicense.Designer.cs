namespace DrivingVehicleLicenseDepartment.Forms.Licenses.DetainLicenses
{
    partial class frmDetainLicense
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
            this.btnDetain = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.ctrlDetainLicenseWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlDetainLicenseWithFilter();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(327, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(249, 35);
            this.kryptonLabel1.TabIndex = 38;
            this.kryptonLabel1.Values.Text = "Detain license";
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(514, 681);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(234, 27);
            this.lblShowLicenseInfo.TabIndex = 36;
            this.lblShowLicenseInfo.Values.Text = "Show license information";
            this.lblShowLicenseInfo.LinkClicked += new System.EventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(514, 708);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(256, 27);
            this.lblShowLicenseHistory.TabIndex = 37;
            this.lblShowLicenseHistory.Values.Text = "Show driver licenses history";
            this.lblShowLicenseHistory.LinkClicked += new System.EventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.Enabled = false;
            this.btnDetain.Location = new System.Drawing.Point(63, 681);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(216, 52);
            this.btnDetain.TabIndex = 34;
            this.btnDetain.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDetain.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Detained_Driving_License_32;
            this.btnDetain.Values.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 681);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 35;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlDetainLicenseWithFilter1
            // 
            this.ctrlDetainLicenseWithFilter1.detainedLicenses = null;
            this.ctrlDetainLicenseWithFilter1.EnableFees = false;
            this.ctrlDetainLicenseWithFilter1.License = null;
            this.ctrlDetainLicenseWithFilter1.Location = new System.Drawing.Point(8, 56);
            this.ctrlDetainLicenseWithFilter1.Name = "ctrlDetainLicenseWithFilter1";
            this.ctrlDetainLicenseWithFilter1.Size = new System.Drawing.Size(829, 614);
            this.ctrlDetainLicenseWithFilter1.TabIndex = 39;
            this.ctrlDetainLicenseWithFilter1.OnLicenseSelected += new System.EventHandler(this.ctrlDetainLicenseWithFilter1_OnLicenseSelected);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(843, 751);
            this.Controls.Add(this.ctrlDetainLicenseWithFilter1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseInfo;
        private Krypton.Toolkit.KryptonLinkLabel lblShowLicenseHistory;
        private Krypton.Toolkit.KryptonButton btnDetain;
        private Krypton.Toolkit.KryptonButton btnClose;
        private CustomControls.ctrlDetainLicenseWithFilter ctrlDetainLicenseWithFilter1;
    }
}