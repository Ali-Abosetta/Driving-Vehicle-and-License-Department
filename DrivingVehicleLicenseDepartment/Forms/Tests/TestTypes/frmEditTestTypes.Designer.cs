namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestTyps
{
    partial class frmEditTestTypes
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
            this.lblID = new Krypton.Toolkit.KryptonLabel();
            this.txtFees = new Krypton.Toolkit.KryptonTextBox();
            this.txtTitle = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rtbDescription = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(168, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(143, 27);
            this.lblID.TabIndex = 22;
            this.lblID.Values.Text = "ID";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(168, 205);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(308, 30);
            this.txtFees.TabIndex = 21;
            this.txtFees.Tag = "fees text box";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(168, 145);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(308, 30);
            this.txtTitle.TabIndex = 20;
            this.txtTitle.Tag = "title text box";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(8, 149);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(143, 27);
            this.kryptonLabel4.TabIndex = 19;
            this.kryptonLabel4.Values.Text = "Tilte:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(8, 209);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(143, 27);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Fees:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(8, 89);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(143, 27);
            this.kryptonLabel2.TabIndex = 17;
            this.kryptonLabel2.Values.Text = "Test Type ID:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(118, 21);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(312, 35);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "Update Test Type";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 52);
            this.btnSave.TabIndex = 14;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Save_32;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(254, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 52);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnCancel.Values.Text = "Close";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(168, 261);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(308, 125);
            this.rtbDescription.TabIndex = 24;
            this.rtbDescription.Text = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 261);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(143, 27);
            this.kryptonLabel5.TabIndex = 25;
            this.kryptonLabel5.Values.Text = "Description:";
            // 
            // frmEditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 481);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmEditTestTypes";
            this.Text = "frmEditTestTypes";
            this.Load += new System.EventHandler(this.frmEditTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblID;
        private Krypton.Toolkit.KryptonTextBox txtFees;
        private Krypton.Toolkit.KryptonTextBox txtTitle;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonRichTextBox rtbDescription;
    }
}