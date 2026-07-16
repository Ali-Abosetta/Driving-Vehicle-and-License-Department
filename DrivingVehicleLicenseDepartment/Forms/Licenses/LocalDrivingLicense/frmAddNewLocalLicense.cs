using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DrivingVehicleLicenseDepartment.CustomControls;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.Forms.Licenses.LocalDrivingLicense
{
    public partial class frmAddNewLocalLicense : KryptonForm
    {
        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;


        private Users user;
        public frmAddNewLocalLicense()
        {
            InitializeComponent();
            addEditApplication1.User = user;
        }

        public frmAddNewLocalLicense(int UserID)
        {
            InitializeComponent();

            Users user = Users.Find(UserID);

            People person = People.Find(user.PersonID);
            personInfroWithFilter1.ctrlPersonCardEditable1.Person = person;

            btnNext.Enabled = true;
            addEditApplication1.User = user;
        }

        public frmAddNewLocalLicense(Users user)
        {
            InitializeComponent();

            this.user = user;
            addEditApplication1.User = user;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(user != null)
                addEditApplication1.User = user;

            tabControl1.SelectedIndex = 1;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void personInfroWithFilter1_OnPersonSelected(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnSave.Enabled = true;

            addEditApplication1.ApplicantPersonID = personInfroWithFilter1.PersonID;
        }

        private void personInfroWithFilter1_OnPersonNotFound(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            int FoundApplicationID = LocalDrivingLicenseApplications
                .HasActiveApplicationForClass
                (personInfroWithFilter1.PersonID, addEditApplication1.LicenseClassID);
            if (!(FoundApplicationID > 0))
            {
                if (addEditApplication1.Application.Save())
                {

                    LocalDrivingLicenseApplications LocalApp
                        = new LocalDrivingLicenseApplications();

                    LocalApp.ApplicationID = addEditApplication1.Application.ApplicationID;
                    LocalApp.LicenseClassID = addEditApplication1.LicenseClassID;

                    if (LocalApp.Save())
                    {
                        DataBack?.Invoke();

                        KryptonMessageBox.Show("Data Saved Successfully.",
                        "Saved", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information, false);

                        addEditApplication1.refresh();
                    }

                    else
                    {
                        KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                            "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                    }
                }

                else
                {
                    KryptonMessageBox.Show("Error: Data Is not Saved Successfully.",
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
                }
            }
            else
            {
                string message = "Choose another License Class, the selected Person" +
                     " already has an active application for the selected " +
                    $"class with ID = {FoundApplicationID}";
                KryptonMessageBox.Show(message,
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, false);
            }

        }

    }
}
