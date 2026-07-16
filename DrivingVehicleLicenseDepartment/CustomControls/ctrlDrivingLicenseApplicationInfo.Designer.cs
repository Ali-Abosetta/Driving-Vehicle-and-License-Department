namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlDrivingLicenseApplicationInfo
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
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLinkLabel1 = new Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLinkLabel1);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroup1.Size = new System.Drawing.Size(784, 189);
            this.kryptonGroup1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(55, 25);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(115, 25);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "D.L Application ID:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(55, 56);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(123, 25);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Applied For License:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(55, 87);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(123, 25);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Passed Tests:";
            // 
            // kryptonLinkLabel1
            // 
            this.kryptonLinkLabel1.Location = new System.Drawing.Point(55, 118);
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Size = new System.Drawing.Size(109, 25);
            this.kryptonLinkLabel1.TabIndex = 2;
            this.kryptonLinkLabel1.Values.Text = "Show License Info";
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "ctrlDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(784, 189);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}
