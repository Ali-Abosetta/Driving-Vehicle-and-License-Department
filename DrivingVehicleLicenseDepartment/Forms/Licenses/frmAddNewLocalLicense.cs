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
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses
{
    public partial class frmAddNewLocalLicense : KryptonForm
    {

        public frmAddNewLocalLicense()
        {
            InitializeComponent();
        }

        public frmAddNewLocalLicense(int UserID)
        {
            InitializeComponent();

            Users user = Users.Find(UserID);

            People person = People.Find(user.PersonID);
            personInfroWithFilter1.ctrlPersonCardEditable1.Person = person;


            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
