using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DrivingVehicleLicenseDepartment.CustomControls;
using Enum;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Users
{
    public partial class frmAddEditUser : KryptonForm
    {

        public delegate void DataBackEventHandler(object sender, BLL.Users user);
        public event DataBackEventHandler DataBack;

        private enMode _Mode;

        private BLL.Users _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            this.Text = "Add new user";
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            this.Text = "Edit user";

            _User = BLL.Users.Find(UserID);
            addEditUser1.User = _User;

            BLL.People person = _User.PersonInfo;
            personInfroWithFilter1.ctrlPersonCard1.Person = person;

            personInfroWithFilter1.Filter = false;

            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_User != null)
            {
                addEditUser1.User = _User;
            }

            btnSave.Enabled = true;

            tabControl1.SelectedIndex = 1;
            btnPrevious.Focus();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnNext.Focus();
            btnSave.Enabled = false;
        }

        private void personInfroWithFilter1_OnPersonSelected(object sender, EventArgs e)
        { 
            
            int SelectedPersonID = personInfroWithFilter1.PersonID;

            if (_Mode == enMode.AddNew && BLL.Users.IsExistsByPersonID(SelectedPersonID))
            {
                KryptonMessageBox.Show("This person already has a user account linked to them!",
                    "Warning", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning, false);
                return;
            }


            btnNext.Enabled = true;
        }

        private void personInfroWithFilter1_OnPersonNotFound(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!addEditUser1.AreBoxesFilled)
            {
                KryptonMessageBox.Show($"Please fillout the user information first {Environment.NewLine}" +
                    $"and take a look at the validation messages on the red points.",
                    "Not Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                return;
            }

            BLL.Users user = addEditUser1.User;
            user.PersonID = personInfroWithFilter1.PersonID;

            if (user.Save())
            {
                addEditUser1.User = user;

                KryptonMessageBox.Show("Data Saved Successfully.",
                "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information,false);

                DataBack?.Invoke(this, user);
                this.Close();
            }

            else
            {
                KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
