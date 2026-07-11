namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class UserCardEditable
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
            BLL.People people1 = new BLL.People();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.lblActive = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.lblUserName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblUserID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlPersonCardEditable1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlPersonCardEditable();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 383);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblActive);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblUserName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblUserID);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(875, 110);
            this.kryptonGroupBox1.TabIndex = 1;
            // 
            // lblActive
            // 
            this.lblActive.Location = new System.Drawing.Point(673, 24);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(122, 27);
            this.lblActive.TabIndex = 18;
            this.lblActive.Values.Text = "[????]";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(581, 24);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel5.TabIndex = 17;
            this.kryptonLabel5.Values.Text = "Is active:";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(453, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(122, 27);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Values.Text = "[????]";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(349, 24);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel3.TabIndex = 15;
            this.kryptonLabel3.Values.Text = "Username:";
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(98, 24);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(122, 27);
            this.lblUserID.TabIndex = 14;
            this.lblUserID.Values.Text = "[????]";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(19, 24);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel6.TabIndex = 13;
            this.kryptonLabel6.Values.Text = "User ID:";
            // 
            // ctrlPersonCardEditable1
            // 
            this.ctrlPersonCardEditable1.Location = new System.Drawing.Point(3, 0);
            this.ctrlPersonCardEditable1.Name = "ctrlPersonCardEditable1";
            people1.Address = "";
            people1.DateOfBirth = new System.DateTime(2008, 6, 30, 7, 44, 34, 57);
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
            this.ctrlPersonCardEditable1.Size = new System.Drawing.Size(881, 377);
            this.ctrlPersonCardEditable1.TabIndex = 0;
            // 
            // UserCardEditable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.ctrlPersonCardEditable1);
            this.Name = "UserCardEditable";
            this.Size = new System.Drawing.Size(881, 500);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCardEditable ctrlPersonCardEditable1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel lblActive;
        private Krypton.Toolkit.KryptonLabel lblUserName;
        private Krypton.Toolkit.KryptonLabel lblUserID;
    }
}
