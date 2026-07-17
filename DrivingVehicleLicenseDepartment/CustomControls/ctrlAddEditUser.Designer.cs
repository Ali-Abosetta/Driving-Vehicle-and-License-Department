namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlAddEditUser
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
            this.components = new System.ComponentModel.Container();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblUserID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new Krypton.Toolkit.KryptonTextBox();
            this.chkActive = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(35, 31);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 27);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "UserID:";
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(237, 31);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(90, 27);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Values.Text = "N\\A";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(35, 74);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(109, 27);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "UserName:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(35, 160);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(176, 27);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "Confirm Password:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(35, 117);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(101, 27);
            this.kryptonLabel7.TabIndex = 6;
            this.kryptonLabel7.Values.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(237, 74);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(257, 30);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(237, 160);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(257, 30);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(237, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(257, 30);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(35, 208);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(107, 27);
            this.chkActive.TabIndex = 10;
            this.chkActive.Values.Text = "Is Active?";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(3, 4);
            this.kryptonGroup1.Size = new System.Drawing.Size(584, 272);
            this.kryptonGroup1.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "AddEditUser";
            this.Size = new System.Drawing.Size(590, 279);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblUserID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonCheckBox chkActive;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Krypton.Toolkit.KryptonTextBox txtUsername;
        public Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        public Krypton.Toolkit.KryptonTextBox txtPassword;
    }
}
