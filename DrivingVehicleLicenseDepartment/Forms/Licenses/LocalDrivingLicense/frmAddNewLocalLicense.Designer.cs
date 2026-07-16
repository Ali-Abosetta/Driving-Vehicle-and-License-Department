namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
{
    partial class frmAddNewLocalLicense
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.btnPrevious = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.personInfroWithFilter1 = new DrivingVehicleLicenseDepartment.CustomControls.PersonInfoWithFilter();
            this.addEditApplication1 = new DrivingVehicleLicenseDepartment.CustomControls.AddEditApplication();
            this.tabControl1.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonalInfo);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 570);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 17;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.personInfroWithFilter1);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 5);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(903, 561);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(755, 485);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 46);
            this.btnNext.TabIndex = 14;
            this.btnNext.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNext.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Next_32;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.addEditApplication1);
            this.tpApplicationInfo.Controls.Add(this.btnPrevious);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 5);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(903, 561);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(8, 509);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 46);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPrevious.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Prev_32;
            this.btnPrevious.Values.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2, 587);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 52);
            this.btnSave.TabIndex = 18;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Save_32;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(239, 587);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 19;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // personInfroWithFilter1
            // 
            this.personInfroWithFilter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.personInfroWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.personInfroWithFilter1.Name = "personInfroWithFilter1";
            this.personInfroWithFilter1.Size = new System.Drawing.Size(897, 485);
            this.personInfroWithFilter1.TabIndex = 0;
            this.personInfroWithFilter1.OnPersonSelected += new System.EventHandler(this.personInfroWithFilter1_OnPersonSelected);
            this.personInfroWithFilter1.OnPersonNotFound += new System.EventHandler(this.personInfroWithFilter1_OnPersonNotFound);
            // 
            // addEditApplication1
            // 
            this.addEditApplication1.Location = new System.Drawing.Point(128, 77);
            this.addEditApplication1.Name = "addEditApplication1";
            this.addEditApplication1.Size = new System.Drawing.Size(668, 369);
            this.addEditApplication1.TabIndex = 16;
            // 
            // frmAddNewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 646);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddNewLocalLicense";
            this.Text = "frmAddNewLocalLicense";
            this.tabControl1.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private Krypton.Toolkit.KryptonButton btnNext;
        private CustomControls.PersonInfoWithFilter personInfroWithFilter1;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private Krypton.Toolkit.KryptonButton btnPrevious;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClose;
        private CustomControls.AddEditApplication addEditApplication1;
    }
}