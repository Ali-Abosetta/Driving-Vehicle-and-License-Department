using System;
using System.Windows.Forms;
using BLL;
using Enum;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment
{

    

    public partial class frmAddEditPerson : KryptonForm
    {
        private enMode _Mode;
        private int _PersonID;

        public delegate void DataBackEventHandler(object sender, People Person);
        public event DataBackEventHandler DataBack;

        public frmAddEditPerson()
        {
            InitializeComponent();
            InitializeAddNewMode();
        }
        public void InitializeAddNewMode()
        {
            lblTitle.Text = "Add New Person";
            _Mode = enMode.AddNew;
            ctrlPersonCardEditable1.Person.Mode = _Mode;
        }
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            InitializeUpdateMode(PersonID);
            ctrlPersonCardEditable1.Person = People.Find(PersonID);
            ctrlPersonCardEditable1.Person.Mode = _Mode;
        }
        public void InitializeUpdateMode(int PersonID)
        {
            lblTitle.Text = "Update Person";
            lblID.Text = PersonID.ToString();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ctrlPersonCardEditable1.Person.Save())
            {
                KryptonMessageBox.Show("Data Saved Successfully.",
                    "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                DataBack?.Invoke(this, ctrlPersonCardEditable1.Person);
                InitializeUpdateMode(ctrlPersonCardEditable1.Person.PersonID);
                this.Close();
            }

            else
            {
                KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}
