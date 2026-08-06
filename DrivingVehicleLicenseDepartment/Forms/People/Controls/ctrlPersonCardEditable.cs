using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BLL;
using DrivingVehicleLicenseDepartment.Properties;
using Krypton.Toolkit;
using static BLL.Utils.clsValidation;

namespace DrivingVehicleLicenseDepartment.Forms.People.Controls
{
    public partial class ctrlPersonCardEditable : UserControl
    {

        private DataTable _dtCountries;
        private string _ImagePath = null;

        private bool IsValidNationalNo = false;
        public bool IsValid
        {
            get
            {
                return
                    !((
                        string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                        string.IsNullOrWhiteSpace(txtSecondName.Text) ||
                        string.IsNullOrWhiteSpace(txtLastName.Text) ||
                        string.IsNullOrWhiteSpace(txtNational.Text) ||
                        string.IsNullOrWhiteSpace(txtPhone.Text) ||
                        string.IsNullOrWhiteSpace(rtbAddress.Text) ||
                        !IsValidNationalNo ||
                        (
                            !IsValidEmail(txtEmail.Text) && 
                            !string.IsNullOrWhiteSpace(txtEmail.Text)
                        )
                    )
                );
            }
        }

        private BLL.People _person  = new BLL.People();
        public BLL.People Person
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

                    _ImagePath = value.ImagePath;
                    pbPicture.ImageLocation = _ImagePath;

                    if(!string.IsNullOrWhiteSpace(_ImagePath))
                    {
                        lblRemovePic.Visible = true;
                        lblRemovePic.Enabled = true;
                    }

                    else
                    {
                        lblRemovePic.Visible = false;
                        lblRemovePic.Enabled = false;
                    }

                    _person = value;
                    IsValidNationalNo = true;

                }

                else
                {
                    _ResetFields();
                }
            }
        }
        public ctrlPersonCardEditable()
        {
            InitializeComponent();
            dtpBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirth.Value = dtpBirth.MaxDate;
            dtpBirth.MinDate = DateTime.Now.AddYears(-120);
        }

        private void _ResetFields()
        {
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            txtNational.Text = string.Empty;
            dtpBirth.Value = dtpBirth.MinDate;

            txtPhone.Text = string.Empty;

            rbMale.Checked = true;
            rbFemale.Checked = false;

            txtEmail.Text = string.Empty;
            cmbCountries.SelectedValue = 100; //Libya

            rtbAddress.Text = string.Empty;

            pbPicture.ImageLocation = Properties.Resources.Male_512.ToString();
        }

        private void _LoadCountries()
        {
            _dtCountries = Countries.GetAllCountries();
            cmbCountries.DataSource = _dtCountries;
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
            cmbCountries.SelectedValue = 100; //this is libya 
        }
        private void ctrlPersonCardEditable_Load(object sender, EventArgs e)
        {
            _LoadCountries();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (_ImagePath == null)
            {
                if (rbMale.Checked)
                {
                    pbPicture.Image = Resources.Male_512;
                }
                else
                {
                    pbPicture.Image = Resources.Female_512;
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

        private void lblEditPic_LinkClicked(object sender, EventArgs e)
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

                if(_ImagePath != null)
                {
                    try
                    {
                        File.Delete(_ImagePath);
                    }
                    catch (IOException)
                    {
                        throw;
                    }
                }

                _ImagePath = destinationPath;
                pbPicture.ImageLocation = _ImagePath;
                _person.ImagePath = destinationPath;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Please enter a valid email address.");
                e.Cancel = false;
            }

            else
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
        }

        private void lblRemovePic_LinkClicked(object sender, EventArgs e)
        {

            bool Confirmed = KryptonMessageBox.Show("Are you sure you want to remove this person's pictsure?",
                "Confirmation", KryptonMessageBoxButtons.YesNo, 
                KryptonMessageBoxIcon.Warning, false) == DialogResult.Yes;

            if (Confirmed)
            {
                lblRemovePic.Enabled = false;
                lblRemovePic.Visible = false;

                if (_ImagePath != null)
                {
                    try
                    {
                        File.Delete(_ImagePath);
                    }
                    catch (IOException)
                    {
                        throw;
                    }
                }

                _person.ImagePath = null;
                _ImagePath = null;

                pbPicture.Image = rbMale.Checked? Resources.Male_512 : Resources.Female_512; 
            }
        }

        private void NationalNo_Validating(object sender, CancelEventArgs e)
        {
            RequiredTextBox_Validating(sender, e);

            if(txtNational.Text != _person.NationalNo.ToString() 
                && BLL.People.IsExistsByNationalNo(txtNational.Text))
            {
                errorProvider1.SetError(txtNational, "This national number is already on the system.");
                e.Cancel = false;
                IsValidNationalNo = false;
            }

            else
            {
                errorProvider1.SetError(txtNational, string.Empty);
                IsValidNationalNo = true;
            }
        }

        private void OnlyLettersTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void OnlyDigitsTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
