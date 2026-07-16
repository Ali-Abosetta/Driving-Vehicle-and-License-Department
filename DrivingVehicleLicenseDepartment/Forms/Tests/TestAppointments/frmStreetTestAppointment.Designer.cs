namespace DrivingVehicleLicenseDepartment.Forms.Tests.TestAppointments
{
    partial class frmStreetTestAppointment
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
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.PaletteDGVs = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.btnSchedule = new Krypton.Toolkit.KryptonButton();
            this.ctrlApplicationBasicInfo1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlApplicationBasicInfo();
            this.ctrlDrivingLicenseApplicationInfo1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlDrivingLicenseApplicationInfo();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(6, 644);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Palette = this.PaletteDGVs;
            this.kryptonDataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(784, 162);
            this.kryptonDataGridView1.TabIndex = 23;
            // 
            // PaletteDGVs
            // 
            this.PaletteDGVs.BaseFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaletteDGVs.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(6, 609);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(92, 25);
            this.kryptonLabel2.TabIndex = 22;
            this.kryptonLabel2.Values.Text = "Appointments:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(269, 144);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(237, 35);
            this.kryptonLabel1.TabIndex = 19;
            this.kryptonLabel1.Values.Text = "Street Test Appointments";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(6, 812);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 52);
            this.btnClose.TabIndex = 25;
            this.btnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClose.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Close_32;
            this.btnClose.Values.Text = "Close";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(639, 590);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(151, 44);
            this.btnSchedule.TabIndex = 24;
            this.btnSchedule.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSchedule.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Schedule_Test_321;
            this.btnSchedule.Values.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.application = null;
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(6, 331);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(784, 247);
            this.ctrlApplicationBasicInfo1.TabIndex = 21;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.LocalApp = null;
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(4, 191);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(784, 133);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 20;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointments.Name = "cmsAppointments";
            this.cmsAppointments.Size = new System.Drawing.Size(137, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Location = new System.Drawing.Point(301, 10);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(170, 128);
            this.kryptonPictureBox1.TabIndex = 18;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // frmStreetTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 875);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.kryptonPictureBox1);
            this.Name = "frmStreetTestAppointment";
            this.Text = "frmStreetTestAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        public Krypton.Toolkit.KryptonCustomPaletteBase PaletteDGVs;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSchedule;
        private CustomControls.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private CustomControls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}