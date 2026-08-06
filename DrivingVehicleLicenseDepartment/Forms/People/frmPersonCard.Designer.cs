namespace DrivingVehicleLicenseDepartment.Forms.People
{
    partial class frmPersonCard
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
            this.ctrlPersonCard1 = new DrivingVehicleLicenseDepartment.Forms.People.Controls.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 52);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(-3, 14);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Person = null;
            this.ctrlPersonCard1.Size = new System.Drawing.Size(881, 377);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // frmPersonCard
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(876, 467);
            this.ControlBox = false;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person card";
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Controls.ctrlPersonCard ctrlPersonCard1;
    }
}