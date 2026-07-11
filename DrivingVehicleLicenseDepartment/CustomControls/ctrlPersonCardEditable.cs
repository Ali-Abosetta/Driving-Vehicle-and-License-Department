using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class ctrlPersonCardEditable : UserControl
    {

        private DataTable _dtCountries;
        private string _ImagePath = null;

        private People _person  = new People();
        public People Person
        {
            get
            {

                _person.FirstName = txtFirstName.Text;
                _person.SecondName = txtSecondName.Text;
                _person.ThirdName = txtThirdName.Text;
                _person.LastName = txtLastName.Text;

                _person.NationalNo = txtNational.Text;
                _person.DateOfBirth = dtpBirth.Value;

                _person.Phone = txtPhone.Text;
                _person.Gendor = rbMale.Checked ? 0 : 1;

                _person.Email = txtEmail.Text;
                _person.NationalityCountryID = Convert.ToInt32(cmbCountries.SelectedValue);

                _person.Address = rtbAddress.Text;

                _person.ImagePath = _ImagePath;

                return _person;
            }

            set
            {

                if (value != null)
                {
                    txtFirstName.Text = value.FirstName;
                    txtSecondName.Text = value.SecondName;
                    txtThirdName.Text = value.ThirdName;
                    txtLastName.Text = value.LastName;

                    txtNational.Text = value.NationalNo;
                    dtpBirth.Value = value.DateOfBirth;

                    txtPhone.Text = value.Phone;

                    rbMale.Checked = value.Gendor == 0;
                    rbFemale.Checked = value.Gendor == 1;

                    txtEmail.Text = value.Email;
                    cmbCountries.SelectedValue = value.NationalityCountryID;

                    rtbAddress.Text = value.Address;
                    pbPicture.ImageLocation = value.ImagePath;
                    _ImagePath = value.ImagePath;

                    _person = value;

                }
            }
        }
        public ctrlPersonCardEditable()
        {
            InitializeComponent();
            dtpBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void ctrlPersonCardEditable_Load(object sender, EventArgs e)
        {
            _dtCountries = Countries.GetAllCountries();
            cmbCountries.DataSource = _dtCountries;
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedValue = 100;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (_ImagePath == null)
            {
                if (rbMale.Checked)
                {
                    pbPicture.Image = Properties.Resources.Male_512;
                }
                else
                {
                    pbPicture.Image = Properties.Resources.Female_512;
                }
            }
        }

        private void RequiredTextBox_Validating(object sender, CancelEventArgs e)
        {
            KryptonTextBox textBox = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, $"{textBox.Tag} is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void lblPicture_LinkClicked(object sender, EventArgs e)
        {

            ofdEditPicture.InitialDirectory = @"C:\Users\ali\Downloads";
            ofdEditPicture.DefaultExt = "jpeg";
            ofdEditPicture.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if(ofdEditPicture.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofdEditPicture.FileName);
                string fileName = Guid.NewGuid().ToString() + extension;

                string destinationFolder = 
                    Path.Combine(Application.StartupPath, "Images");

                Directory.CreateDirectory(destinationFolder);

                string destinationPath = 
                    Path.Combine(destinationFolder, fileName);

                File.Copy(ofdEditPicture.FileName, destinationPath);

                _ImagePath = destinationPath;
                pbPicture.ImageLocation = _ImagePath;
                _person.ImagePath = destinationPath;
            }
        }
    }
}
