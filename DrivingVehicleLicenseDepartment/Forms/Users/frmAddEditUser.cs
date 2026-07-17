using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartment.CustomControls;
using BLL;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms
{
    public partial class frmAddEditUser : KryptonForm
    {

        public delegate void DataBackEventHandler(object sender, Users user);
        public event DataBackEventHandler DataBack;

        private Users user;
        public frmAddEditUser()
        {
            InitializeComponent();
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            user = Users.Find(UserID);
            addEditUser1.User = user;

            People person = user.PersonInfo;
            personInfroWithFilter1.ctrlPersonCardEditable1.Person = person;


            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (user != null)
                addEditUser1.User = user;

            tabControl1.SelectedIndex = 1;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void personInfroWithFilter1_OnPersonSelected(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

        private void personInfroWithFilter1_OnPersonNotFound(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Users user = addEditUser1.User;
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
