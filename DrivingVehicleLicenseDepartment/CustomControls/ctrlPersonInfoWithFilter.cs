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

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class ctrlPersonInfoWithFilter  : UserControl
    {

        public event EventHandler OnPersonSelected;
        public event EventHandler OnPersonNotFound;
        List<string> ComboBoxItems { get; set; } = new List<string>();
        public int PersonID { 
            get 
            {
                return ctrlPersonCardEditable1.Person.PersonID;
            }
            
        }
        public ctrlPersonInfoWithFilter ()
        {
            InitializeComponent();
            ctrlPersonCardEditable1.Enabled = false;
        }

        private void AddPerson(object sender, People person)
        {
            this.ctrlPersonCardEditable1.Person = person;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (frmAddEditPerson addPerson = new frmAddEditPerson())
            {
                addPerson.DataBack += AddPerson;
                if (addPerson.ShowDialog() == DialogResult.OK)
                {
                    addPerson.Close();
                }
            }
        }

        private void PersonInfroWithFilter_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
        }


        private void _NotFoundMessageBox(string message = "")
        {
            KryptonMessageBox.Show(message,
                "Not found", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Error);
        }
        private void Search(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                return;

            string selectedFilter = cmbFilter.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(selectedFilter))
            {
                People person = null;

                switch (selectedFilter)
                {
                    case "National No.":

                        person = People.FindByNationalNo(txtSearch.Text.Trim());
                            if (person == null)
                            {
                                _NotFoundMessageBox($"This {selectedFilter}" +
                                    $" is not found on the system's people.");
                            }
                        ctrlPersonCardEditable1.Person = person;
                        break;

                    case "PersonID":
                        if (int.TryParse(txtSearch.Text.Trim(), out int personID))
                        {
                            person = People.Find(personID);
                            if (person == null)
                            {
                                _NotFoundMessageBox($"This {selectedFilter} " +
                                    $"is not found on the system's people.");
                            }
                            ctrlPersonCardEditable1.Person = person;
                        }
                        else
                        {
                            KryptonMessageBox.Show("Please enter a valid number.", "Warning",
                                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                            return;
                        }
                        break;
                }
                if (person != null)
                {
                    OnPersonSelected?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    OnPersonNotFound?.Invoke(this, EventArgs.Empty);
                }
            }

        }
    }
}
