namespace DrivingVehicleLicenseDepartment
{
    partial class frmAddEditPerson
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
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblID = new Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.ctrlPersonCardEditable1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlPersonCardEditable();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(249, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 52);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnCancel.Values.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 52);
            this.btnSave.TabIndex = 2;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Save_32;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 44);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(102, 27);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Person ID: ";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(120, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 27);
            this.lblID.TabIndex = 6;
            this.lblID.Values.Text = "N/A";
            // 
            // lblTitle
            // 
            this.lblTitle.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblTitle.Location = new System.Drawing.Point(327, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 35);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Values.Text = "kryptonLabel2";
            // 
            // ctrlPersonCardEditable1
            // 
            this.ctrlPersonCardEditable1.Location = new System.Drawing.Point(12, 77);
            this.ctrlPersonCardEditable1.Name = "ctrlPersonCardEditable1";
            people1.Address = "";
            people1.DateOfBirth = new System.DateTime(2008, 6, 30, 7, 41, 56, 36);
            people1.Email = "";
            people1.FirstName = "";
            people1.Gendor = 0;
            people1.ImagePath = null;
            people1.LastName = "";
            people1.NationalityCountryID = 100;
            people1.NationalNo = "";
            people1.PersonID = -1;
            people1.Phone = "";
            people1.SecondName = "";
            people1.ThirdName = "";
            this.ctrlPersonCardEditable1.Person = people1;
            this.ctrlPersonCardEditable1.Size = new System.Drawing.Size(868, 377);
            this.ctrlPersonCardEditable1.TabIndex = 0;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ctrlPersonCardEditable1);
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ctrlPersonCardEditable ctrlPersonCardEditable1;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblID;
        private Krypton.Toolkit.KryptonLabel lblTitle;
    }
}