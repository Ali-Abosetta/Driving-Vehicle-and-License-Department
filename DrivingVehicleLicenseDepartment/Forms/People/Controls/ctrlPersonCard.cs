using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrivingVehicleLicenseDepartment.Properties;

namespace DrivingVehicleLicenseDepartment.Forms.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {

        private BLL.People _Person;
        public BLL.People Person
        {
            get
            {
                return _Person;
            }

            set
            {
                if (value != null)
                {
                    lblID.Text = value.PersonID.ToString();
                    lblName.Text = value.FullName;
                    lblNationalNo.Text = value.NationalNo;
                    lblGender.Text = value.Gendor == 0 ? "Male" : "Female";
                    lblEmail.Text = value.Email;
                    lblDateOfBirth.Text = value.DateOfBirth.ToString("dd/MM/yyyy");
                    lblPhone.Text = value.Phone;
                    lblNationality.Text = value.CountryInfo.CountryName;

                    rtbAddress.Text = value.Address;
                    pbPicture.ImageLocation = value.ImagePath;

                    _Person = value;
                }
                else
                {
                    _ResetUI();
                }
            }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _ResetUI()
        {

            lblID.Text = "N/A";
            lblName.Text = "N/A";
            lblNationalNo.Text = "N/A";
            lblGender.Text = "N/A";
            lblEmail.Text = "N/A";
            lblDateOfBirth.Text = "N/A";
            lblPhone.Text = "N/A";
            lblNationality.Text = "N/A";

            rtbAddress.Text = string.Empty;
            pbPicture.Image = Resources.Male_512;
            pbPicture.ImageLocation = null;

        }

        private void lblEditPerson_LinkClicked(object sender, EventArgs e)
        {
            using (frmAddEditPerson frm = new frmAddEditPerson(_Person))
            {
                frm.ShowDialog();
            }
        }
    }
}
