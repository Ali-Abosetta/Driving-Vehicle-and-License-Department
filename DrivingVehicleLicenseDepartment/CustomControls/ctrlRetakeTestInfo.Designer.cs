namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlRetakeTestInfo
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
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.lblTotalFees = new Krypton.Toolkit.KryptonLabel();
            this.lblClass = new Krypton.Toolkit.KryptonLabel();
            this.lblFees = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 0);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblTotalFees);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblClass);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblFees);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(593, 147);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Retake test information";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Location = new System.Drawing.Point(486, 26);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(123, 27);
            this.lblTotalFees.TabIndex = 11;
            this.lblTotalFees.Values.Text = "0/3";
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(229, 59);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(115, 27);
            this.lblClass.TabIndex = 10;
            this.lblClass.Values.Text = "Class";
            // 
            // lblFees
            // 
            this.lblFees.Location = new System.Drawing.Point(229, 26);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(115, 27);
            this.lblFees.TabIndex = 9;
            this.lblFees.Values.Text = "ID";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(350, 26);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(130, 27);
            this.kryptonLabel3.TabIndex = 7;
            this.kryptonLabel3.Values.Text = "Total fees:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 59);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(192, 27);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Retake application test ID:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(178, 27);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Retake application fees:";
            // 
            // ctrlRetakeTestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "ctrlRetakeTestInfo";
            this.Size = new System.Drawing.Size(601, 150);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonLabel lblTotalFees;
        private Krypton.Toolkit.KryptonLabel lblClass;
        private Krypton.Toolkit.KryptonLabel lblFees;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
