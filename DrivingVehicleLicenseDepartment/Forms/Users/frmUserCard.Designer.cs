namespace DrivingVehicleLicenseDepartment.Forms.Users
{
    partial class frmUserCard
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
            BLL.Users users1 = new BLL.Users();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.userCard1 = new DrivingVehicleLicenseDepartment.Forms.Users.Controls.ctrlUserCard();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 5;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // userCard1
            // 
            this.userCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userCard1.Location = new System.Drawing.Point(0, 0);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(882, 500);
            this.userCard1.TabIndex = 0;
            users1.IsActive = false;
            users1.Password = "";
            users1.PersonID = -1;
            users1.PersonInfo = null;
            users1.UserID = -1;
            users1.UserName = "";
            this.userCard1.User = users1;
            // 
            // frmUserCard
            // 
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(882, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.userCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User card";
            this.ResumeLayout(false);

        }

        #endregion

        private DrivingVehicleLicenseDepartment.Forms.Users.Controls.ctrlUserCard userCard1;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}