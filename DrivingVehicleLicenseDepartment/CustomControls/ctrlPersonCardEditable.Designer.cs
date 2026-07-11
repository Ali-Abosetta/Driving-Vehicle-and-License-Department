namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlPersonCardEditable
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
            this.lblPicture = new Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtFirstName = new Krypton.Toolkit.KryptonTextBox();
            this.txtSecondName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtThirdName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtLastName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.textBoxesPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.txtNational = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.dtpBirth = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.cmbCountries = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.rtbAddress = new Krypton.Toolkit.KryptonRichTextBox();
            this.rbMale = new Krypton.Toolkit.KryptonRadioButton();
            this.rbFemale = new Krypton.Toolkit.KryptonRadioButton();
            this.txtPhone = new Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.pbPicture = new Krypton.Toolkit.KryptonPictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdEditPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPicture
            // 
            this.lblPicture.Location = new System.Drawing.Point(740, 290);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(116, 27);
            this.lblPicture.TabIndex = 13;
            this.lblPicture.Values.Text = "Edit picture";
            this.lblPicture.LinkClicked += new System.EventHandler(this.lblPicture_LinkClicked);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(19, 46);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 27);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Name:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(91, 10);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(115, 27);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(163, 21);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Tag = "First Name";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(291, 43);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(163, 21);
            this.txtSecondName.TabIndex = 2;
            this.txtSecondName.Tag = "Second Name";
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(291, 10);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(137, 27);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Second Name:";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(491, 43);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(163, 21);
            this.txtThirdName.TabIndex = 3;
            this.txtThirdName.Tag = "Third Name";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(491, 10);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Third Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(691, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 21);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Tag = "Last Name";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(691, 10);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(115, 27);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Last Name:";
            // 
            // textBoxesPalette
            // 
            this.textBoxesPalette.BaseFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxesPalette.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // txtNational
            // 
            this.txtNational.Location = new System.Drawing.Point(138, 101);
            this.txtNational.Name = "txtNational";
            this.txtNational.Size = new System.Drawing.Size(193, 21);
            this.txtNational.TabIndex = 5;
            this.txtNational.Tag = "National Number";
            this.txtNational.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(19, 104);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "National No.  ";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(363, 104);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel7.TabIndex = 13;
            this.kryptonLabel7.Values.Text = "Birth Date: ";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(491, 104);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(204, 23);
            this.dtpBirth.TabIndex = 6;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(19, 158);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel8.TabIndex = 15;
            this.kryptonLabel8.Values.Text = "Gender:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(363, 158);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel9.TabIndex = 16;
            this.kryptonLabel9.Values.Text = "Phone:";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(19, 215);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel10.TabIndex = 17;
            this.kryptonLabel10.Values.Text = "Email:";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(363, 215);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel11.TabIndex = 18;
            this.kryptonLabel11.Values.Text = "Country:";
            // 
            // cmbCountries
            // 
            this.cmbCountries.Location = new System.Drawing.Point(491, 213);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(204, 20);
            this.cmbCountries.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbCountries.TabIndex = 11;
            this.cmbCountries.Text = "kryptonComboBox1";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(19, 268);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(122, 27);
            this.kryptonLabel12.TabIndex = 20;
            this.kryptonLabel12.Values.Text = "Address:";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(138, 268);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(557, 96);
            this.rtbAddress.TabIndex = 12;
            this.rtbAddress.Text = "";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(112, 157);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(90, 27);
            this.rbMale.TabIndex = 7;
            this.rbMale.Values.Text = "Male";
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(208, 158);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(90, 27);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.Values.Text = "Female";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(491, 158);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 21);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Tag = "Phone Number";
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextBox_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 21);
            this.txtEmail.TabIndex = 10;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(723, 101);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(140, 180);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ofdEditPicture
            // 
            this.ofdEditPicture.FileName = "openFileDialog1";
            this.ofdEditPicture.Title = "Chose person picture";
            // 
            // ctrlPersonCardEditable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtNational);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.pbPicture);
            this.Name = "ctrlPersonCardEditable";
            this.Size = new System.Drawing.Size(881, 377);
            this.Load += new System.EventHandler(this.ctrlPersonCardEditable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox pbPicture;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtFirstName;
        private Krypton.Toolkit.KryptonTextBox txtSecondName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtThirdName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtLastName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonCustomPaletteBase textBoxesPalette;
        private Krypton.Toolkit.KryptonTextBox txtNational;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonDateTimePicker dtpBirth;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonComboBox cmbCountries;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonRichTextBox rtbAddress;
        private Krypton.Toolkit.KryptonTextBox txtPhone;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog ofdEditPicture;
        public Krypton.Toolkit.KryptonRadioButton rbMale;
        public Krypton.Toolkit.KryptonRadioButton rbFemale;
        public Krypton.Toolkit.KryptonLinkLabel lblPicture;
    }
}
