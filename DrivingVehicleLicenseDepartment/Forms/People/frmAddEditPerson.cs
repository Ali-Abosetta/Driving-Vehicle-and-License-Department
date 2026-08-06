using System;
using System.Windows.Forms;
using BLL;
using Enum;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.People
{
    public partial class frmAddEditPerson : KryptonForm
    {
        private int _PersonID;

        public delegate void DataBackEventHandler(object sender, BLL.People Person);
        public event DataBackEventHandler DataBack;

        public frmAddEditPerson()
        {
            InitializeComponent();
            InitializeAddNewMode();
        }
        public void InitializeAddNewMode()
        {
            lblTitle.Text = "Add New Person";
            this.Text = "Add New Person";
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            InitializeUpdateMode(PersonID);
            ctrlPersonCardEditable1.Person = BLL.People.Find(PersonID);
            IsNullPerson(ctrlPersonCardEditable1.Person);
        }

        private void IsNullPerson(BLL.People person)
        {
            if (person == null)
            {
                KryptonMessageBox.Show("Error: The person is not found in the database!",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);

                this.Close();
            }
        }

        public frmAddEditPerson(BLL.People person)
        {
            IsNullPerson(person);
            InitializeComponent();
            InitializeUpdateMode(person.PersonID);
            ctrlPersonCardEditable1.Person = person;
        }

        public void InitializeUpdateMode(int PersonID)
        {
            lblTitle.Text = "Update Person";
            this.Text = "Update Person";
            lblID.Text = PersonID.ToString();
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ctrlPersonCardEditable1.IsValid)
            {
                KryptonMessageBox.Show("Please fillout the form first and take a look at the validation messages on the red points.",
                    "Not Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                return; 
            }


            if (ctrlPersonCardEditable1.Person.Save())
            {
                KryptonMessageBox.Show("Data Saved Successfully.",
                    "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                DataBack?.Invoke(this, ctrlPersonCardEditable1.Person);
                InitializeUpdateMode(ctrlPersonCardEditable1.Person.PersonID);
                this.Close();
            }

            else
            {
                KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
            }
        }

        private void ctrlPersonCardEditable1_OnIsValidChange(object sender, EventArgs e)
        {
            btnSave.Enabled = ctrlPersonCardEditable1.IsValid;
        }
    }
}
