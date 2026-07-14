namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class AddEditApplication
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
            this.cmbClasses = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblUser = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.lblFees = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.lblDate = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(3, 3);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.cmbClasses);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroup1.Panel.Controls.Add(this.lblUser);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroup1.Panel.Controls.Add(this.lblFees);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroup1.Panel.Controls.Add(this.lblDate);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup1.Panel.Controls.Add(this.lblID);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroup1.Size = new System.Drawing.Size(662, 363);
            this.kryptonGroup1.TabIndex = 0;
            // 
            // cmbClasses
            // 
            this.cmbClasses.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.cmbClasses.Location = new System.Drawing.Point(238, 156);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(396, 20);
            this.cmbClasses.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbClasses.TabIndex = 9;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(40, 158);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(179, 27);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "License Class:";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(238, 268);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(179, 27);
            this.lblUser.TabIndex = 7;
            this.lblUser.Values.Text = "[???]";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(40, 268);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(179, 27);
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "Created By:";
            // 
            // lblFees
            // 
            this.lblFees.Location = new System.Drawing.Point(238, 214);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(179, 27);
            this.lblFees.TabIndex = 5;
            this.lblFees.Values.Text = "15";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(40, 214);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(179, 27);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Application Fees:";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(238, 104);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(179, 27);
            this.lblDate.TabIndex = 3;
            this.lblDate.Values.Text = "[???]";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(40, 104);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(179, 27);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Application Date:";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(238, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(179, 27);
            this.lblID.TabIndex = 1;
            this.lblID.Values.Text = "[???]";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(40, 50);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(179, 27);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "D.L.Application ID:";
            // 
            // AddEditApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "AddEditApplication";
            this.Size = new System.Drawing.Size(668, 369);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblID;
        private Krypton.Toolkit.KryptonComboBox cmbClasses;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblUser;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel lblFees;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}
