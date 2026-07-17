namespace DrivingVehicleLicenseDepartment.Forms
{
    partial class frmChangePassword
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
            this.components = new System.ComponentModel.Container();
            BLL.Users users2 = new BLL.Users();
            this.userCardEditable1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlUserCardEditable();
            this.txtNewPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtCurrentPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userCardEditable1
            // 
            this.userCardEditable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userCardEditable1.Location = new System.Drawing.Point(0, 0);
            this.userCardEditable1.Name = "userCardEditable1";
            this.userCardEditable1.Size = new System.Drawing.Size(887, 500);
            this.userCardEditable1.TabIndex = 0;
            users2.IsActive = false;
            users2.Password = "";
            users2.PersonID = -1;
            users2.UserID = -1;
            users2.UserName = "";
            this.userCardEditable1.User = users2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(214, 549);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(257, 30);
            this.txtNewPassword.TabIndex = 15;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(214, 592);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(257, 30);
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(214, 506);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(257, 30);
            this.txtCurrentPassword.TabIndex = 13;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.kryptonTextBox1_Validating);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(12, 549);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(144, 27);
            this.kryptonLabel7.TabIndex = 12;
            this.kryptonLabel7.Values.Text = "New Password:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 592);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(176, 27);
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.Values.Text = "Confirm Password:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 506);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(173, 27);
            this.kryptonLabel3.TabIndex = 10;
            this.kryptonLabel3.Values.Text = "Current Password:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 52);
            this.btnSave.TabIndex = 16;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Save_32;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 643);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.userCardEditable1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ctrlUserCardEditable userCardEditable1;
        private Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private Krypton.Toolkit.KryptonTextBox txtCurrentPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Krypton.Toolkit.KryptonButton btnSave;
    }
}