namespace DrivingVehicleLicenseDepartment
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
            BLL.Users users2 = new BLL.Users();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.userCardEditable1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlUserCardEditable();
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
            // userCardEditable1
            // 
            this.userCardEditable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userCardEditable1.Location = new System.Drawing.Point(0, 0);
            this.userCardEditable1.Name = "userCardEditable1";
            this.userCardEditable1.Size = new System.Drawing.Size(882, 500);
            this.userCardEditable1.TabIndex = 0;
            users2.IsActive = false;
            users2.Password = "";
            users2.PersonID = -1;
            users2.UserID = -1;
            users2.UserName = "";
            this.userCardEditable1.User = users2;
            // 
            // frmUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 571);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.userCardEditable1);
            this.Name = "frmUserCard";
            this.Text = "frmUserCard";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ctrlUserCardEditable userCardEditable1;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}