namespace DrivingVehicleLicenseDepartment.Forms.Licenses.InternationalDrivingLicense
{
    partial class frmInternationalLicenseCard
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
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlInternationalLicenseCard1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlInternationalLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnCancel.Values.Text = "Close";
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.LicenseView_400;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(348, 12);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(203, 133);
            this.kryptonPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kryptonPictureBox1.TabIndex = 1;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(263, 151);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(371, 35);
            this.kryptonLabel1.TabIndex = 59;
            this.kryptonLabel1.Values.Text = "Driver\'s international license information";
            // 
            // ctrlInternationalLicenseCard1
            // 
            this.ctrlInternationalLicenseCard1.InternationalLicense = null;
            this.ctrlInternationalLicenseCard1.Location = new System.Drawing.Point(12, 192);
            this.ctrlInternationalLicenseCard1.Name = "ctrlInternationalLicenseCard1";
            this.ctrlInternationalLicenseCard1.Size = new System.Drawing.Size(867, 349);
            this.ctrlInternationalLicenseCard1.TabIndex = 0;
            // 
            // frmInternationalLicenseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(889, 597);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.kryptonPictureBox1);
            this.Controls.Add(this.ctrlInternationalLicenseCard1);
            this.Name = "frmInternationalLicenseCard";
            this.Text = "frmInternationalLicenseCard";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ctrlInternationalLicenseCard ctrlInternationalLicenseCard1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}