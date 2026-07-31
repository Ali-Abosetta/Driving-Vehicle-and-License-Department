namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlDetainInfo
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
            this.txtFineFees = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblUser = new Krypton.Toolkit.KryptonLabel();
            this.lblDetainDate = new Krypton.Toolkit.KryptonLabel();
            this.lblLicenseID = new Krypton.Toolkit.KryptonLabel();
            this.lblDetainID = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtFineFees);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblUser);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblDetainDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblLicenseID);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblDetainID);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(820, 188);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Detain informations";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Enabled = false;
            this.txtFineFees.Location = new System.Drawing.Point(233, 94);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(165, 31);
            this.txtFineFees.TabIndex = 9;
            this.txtFineFees.Text = "0";
            this.txtFineFees.TextChanged += new System.EventHandler(this.txtFineFees_TextChanged);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel9.Location = new System.Drawing.Point(418, 55);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(120, 27);
            this.kryptonLabel9.TabIndex = 1;
            this.kryptonLabel9.Values.Text = "Created by:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(51, 94);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(119, 27);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Fine fees: ";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(51, 55);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(149, 27);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Detained date:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel8.Location = new System.Drawing.Point(418, 17);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(119, 27);
            this.kryptonLabel8.TabIndex = 3;
            this.kryptonLabel8.Values.Text = "License ID:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(51, 17);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(126, 27);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Detained ID:";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(617, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(119, 27);
            this.lblUser.TabIndex = 5;
            this.lblUser.Values.Text = "N/A";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.Location = new System.Drawing.Point(233, 55);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(119, 27);
            this.lblDetainDate.TabIndex = 6;
            this.lblDetainDate.Values.Text = "N/A";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.Location = new System.Drawing.Point(617, 17);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(119, 27);
            this.lblLicenseID.TabIndex = 7;
            this.lblLicenseID.Values.Text = "N/A";
            // 
            // lblDetainID
            // 
            this.lblDetainID.Location = new System.Drawing.Point(233, 17);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(119, 27);
            this.lblDetainID.TabIndex = 8;
            this.lblDetainID.Values.Text = "N/A";
            // 
            // ctrlDetainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "ctrlDetainInfo";
            this.Size = new System.Drawing.Size(820, 188);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblUser;
        private Krypton.Toolkit.KryptonLabel lblDetainDate;
        private Krypton.Toolkit.KryptonLabel lblLicenseID;
        private Krypton.Toolkit.KryptonLabel lblDetainID;
        public Krypton.Toolkit.KryptonTextBox txtFineFees;
    }
}
