namespace DrivingVehicleLicenseDepartment
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
            BLL.People people1 = new BLL.People();
            this.ctrlPersonCardEditable1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlPersonCardEditable();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // ctrlPersonCardEditable1
            // 
            this.ctrlPersonCardEditable1.Location = new System.Drawing.Point(0, 1);
            this.ctrlPersonCardEditable1.Name = "ctrlPersonCardEditable1";
            people1.Address = "";
            people1.DateOfBirth = new System.DateTime(2008, 6, 30, 7, 41, 1, 881);
            people1.Email = "";
            people1.FirstName = "";
            people1.Gendor = 0;
            people1.ImagePath = null;
            people1.LastName = "";
            people1.NationalityCountryID = 98;
            people1.NationalNo = "";
            people1.PersonID = -1;
            people1.Phone = "";
            people1.SecondName = "";
            people1.ThirdName = "";
            this.ctrlPersonCardEditable1.Person = people1;
            this.ctrlPersonCardEditable1.Size = new System.Drawing.Size(881, 396);
            this.ctrlPersonCardEditable1.TabIndex = 0;
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
            // frmPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 467);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ctrlPersonCardEditable1);
            this.Name = "frmPersonCard";
            this.Text = "frmPersonCard";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ctrlPersonCardEditable ctrlPersonCardEditable1;
        private Krypton.Toolkit.KryptonButton btnCancel;
    }
}