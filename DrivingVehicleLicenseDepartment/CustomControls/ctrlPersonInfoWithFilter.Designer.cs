namespace DrivingVehicleLicenseDepartment.CustomControls
{
    partial class ctrlPersonInfoWithFilter 
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
            this.gbFilter = new Krypton.Toolkit.KryptonGroupBox();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new Krypton.Toolkit.KryptonButton();
            this.cmbFilter = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ctrlPersonCardEditable1 = new DrivingVehicleLicenseDepartment.CustomControls.ctrlPersonCardEditable();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter.Panel)).BeginInit();
            this.gbFilter.Panel.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Location = new System.Drawing.Point(11, 3);
            // 
            // gbFilter.Panel
            // 
            this.gbFilter.Panel.Controls.Add(this.txtSearch);
            this.gbFilter.Panel.Controls.Add(this.btnSearch);
            this.gbFilter.Panel.Controls.Add(this.btnAddNew);
            this.gbFilter.Panel.Controls.Add(this.cmbFilter);
            this.gbFilter.Panel.Controls.Add(this.kryptonLabel1);
            this.gbFilter.Size = new System.Drawing.Size(875, 93);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.Values.Heading = "Filter";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(326, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 30);
            this.txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(659, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 46);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSearch.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.SearchPerson;
            this.btnSearch.Values.Text = "";
            this.btnSearch.Click += new System.EventHandler(this.Search);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(722, 9);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 46);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNew.Values.Image = global::DrivingVehicleLicenseDepartment.Properties.Resources.AddPerson_321;
            this.btnAddNew.Values.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.Items.AddRange(new object[] {
            "National No.",
            "PersonID"});
            this.cmbFilter.Location = new System.Drawing.Point(114, 16);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(194, 29);
            this.cmbFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.Text = "kryptonComboBox1";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 16);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 27);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Filter by:";
            // 
            // ctrlPersonCardEditable1
            // 
            this.ctrlPersonCardEditable1.Location = new System.Drawing.Point(11, 102);
            this.ctrlPersonCardEditable1.Name = "ctrlPersonCardEditable1";
            people1.Address = "";
            people1.DateOfBirth = new System.DateTime(2008, 6, 30, 20, 35, 27, 112);
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
            this.ctrlPersonCardEditable1.Size = new System.Drawing.Size(875, 377);
            this.ctrlPersonCardEditable1.TabIndex = 0;
            // 
            // PersonInfoWithFilter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonCardEditable1);
            this.Name = "PersonInfoWithFilter";
            this.Size = new System.Drawing.Size(897, 485);
            this.Load += new System.EventHandler(this.PersonInfroWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter.Panel)).EndInit();
            this.gbFilter.Panel.ResumeLayout(false);
            this.gbFilter.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbFilter)).EndInit();
            this.gbFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonGroupBox gbFilter;
        private Krypton.Toolkit.KryptonComboBox cmbFilter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnAddNew;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        public ctrlPersonCardEditable ctrlPersonCardEditable1;
    }
}
