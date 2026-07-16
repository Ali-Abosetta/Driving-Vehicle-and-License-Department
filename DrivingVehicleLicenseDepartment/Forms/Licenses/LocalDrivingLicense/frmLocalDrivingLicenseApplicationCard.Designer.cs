namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
{
    partial class frmLocalDrivingLicenseApplicationCard
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
            this.ctrlApplicationBasicInfo1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlApplicationBasicInfo();
            this.ctrlDrivingLicenseApplicationInfo1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlDrivingLicenseApplicationInfo();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.application = null;
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(4, 153);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(784, 250);
            this.ctrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.LocalApp = null;
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(4, 12);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(784, 135);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(4, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 6;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLocalDrivingLicenseApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 479);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Name = "frmLocalDrivingLicenseApplicationCard";
            this.Text = "frmLocalDrivingLicenseApplicationCard";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private CustomControls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}