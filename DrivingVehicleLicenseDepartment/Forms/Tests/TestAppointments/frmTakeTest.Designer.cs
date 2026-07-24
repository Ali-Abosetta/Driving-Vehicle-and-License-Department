namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments
{
    partial class frmTakeTest
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
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.rtbNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.rbFail = new Krypton.Toolkit.KryptonRadioButton();
            this.rbPass = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblTestID = new Krypton.Toolkit.KryptonLabel();
            this.lblFees = new Krypton.Toolkit.KryptonLabel();
            this.lblDate = new Krypton.Toolkit.KryptonLabel();
            this.lblTrial = new Krypton.Toolkit.KryptonLabel();
            this.lblName = new Krypton.Toolkit.KryptonLabel();
            this.lblDClass = new Krypton.Toolkit.KryptonLabel();
            this.lblDLAppID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lblTitle = new Krypton.Toolkit.KryptonLabel();
            this.pbPicture = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(16, 615);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 83;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Save_32;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(185, 615);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnCancel.Values.Text = "Close";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(112, 484);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(450, 115);
            this.rtbNotes.TabIndex = 82;
            this.rtbNotes.Text = "";
            // 
            // rbFail
            // 
            this.rbFail.Location = new System.Drawing.Point(190, 454);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(139, 25);
            this.rbFail.TabIndex = 81;
            this.rbFail.Values.Text = "Fail";
            this.rbFail.CheckedChanged += new System.EventHandler(this.rbPassRbFail_CheckedChanged);
            // 
            // rbPass
            // 
            this.rbPass.Location = new System.Drawing.Point(112, 454);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(90, 25);
            this.rbPass.TabIndex = 80;
            this.rbPass.Values.Text = "Pass";
            this.rbPass.CheckedChanged += new System.EventHandler(this.rbPassRbFail_CheckedChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(16, 485);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel10.TabIndex = 79;
            this.kryptonLabel10.Values.Text = "Notes:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(16, 454);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel9.TabIndex = 78;
            this.kryptonLabel9.Values.Text = "Result:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(48, 398);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel8.TabIndex = 76;
            this.kryptonLabel8.Values.Text = "Test ID:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(48, 367);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel7.TabIndex = 75;
            this.kryptonLabel7.Values.Text = "Fees:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(48, 336);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel6.TabIndex = 74;
            this.kryptonLabel6.Values.Text = "Date:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(48, 305);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel5.TabIndex = 77;
            this.kryptonLabel5.Values.Text = "Trial:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(48, 274);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel4.TabIndex = 73;
            this.kryptonLabel4.Values.Text = "Name:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(48, 243);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel3.TabIndex = 72;
            this.kryptonLabel3.Values.Text = "D. Class:";
            // 
            // lblTestID
            // 
            this.lblTestID.Location = new System.Drawing.Point(190, 398);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(90, 25);
            this.lblTestID.TabIndex = 71;
            this.lblTestID.Values.Text = "Not taken yet";
            // 
            // lblFees
            // 
            this.lblFees.Location = new System.Drawing.Point(190, 367);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(90, 25);
            this.lblFees.TabIndex = 70;
            this.lblFees.Values.Text = "N/A";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(190, 336);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 25);
            this.lblDate.TabIndex = 69;
            this.lblDate.Values.Text = "N/A";
            // 
            // lblTrial
            // 
            this.lblTrial.Location = new System.Drawing.Point(190, 305);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(90, 25);
            this.lblTrial.TabIndex = 68;
            this.lblTrial.Values.Text = "N/A";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(190, 274);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 67;
            this.lblName.Values.Text = "N/A";
            // 
            // lblDClass
            // 
            this.lblDClass.Location = new System.Drawing.Point(190, 243);
            this.lblDClass.Name = "lblDClass";
            this.lblDClass.Size = new System.Drawing.Size(90, 25);
            this.lblDClass.TabIndex = 66;
            this.lblDClass.Values.Text = "N/A";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.Location = new System.Drawing.Point(190, 212);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(90, 25);
            this.lblDLAppID.TabIndex = 65;
            this.lblDLAppID.Values.Text = "N/A";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(48, 212);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel2.TabIndex = 64;
            this.kryptonLabel2.Values.Text = "D.L.App.ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblTitle.Location = new System.Drawing.Point(174, 171);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 35);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Values.Text = "Scheduled Test";
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(204, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(170, 128);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 62;
            this.pbPicture.TabStop = false;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 669);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDClass);
            this.Controls.Add(this.lblDLAppID);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPicture);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonRichTextBox rtbNotes;
        private Krypton.Toolkit.KryptonRadioButton rbFail;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblTestID;
        private Krypton.Toolkit.KryptonLabel lblFees;
        private Krypton.Toolkit.KryptonLabel lblDate;
        private Krypton.Toolkit.KryptonLabel lblTrial;
        private Krypton.Toolkit.KryptonLabel lblName;
        private Krypton.Toolkit.KryptonLabel lblDClass;
        private Krypton.Toolkit.KryptonLabel lblDLAppID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Krypton.Toolkit.KryptonPictureBox pbPicture;
        public Krypton.Toolkit.KryptonRadioButton rbPass;
    }
}