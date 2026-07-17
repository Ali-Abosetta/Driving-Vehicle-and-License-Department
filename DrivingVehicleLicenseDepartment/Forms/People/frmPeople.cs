using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Krypton.Toolkit;

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmPeople : KryptonForm
    {


        private DataTable _PeopleTable = new DataTable();
        private int SelectedPersonID
        {
            get
            {
                return Convert.ToInt32(
                    dgvPeople.CurrentRow.Cells["Person ID"].Value
                    );
            }
        }

        private void _LoadPeople()
        {
            _PeopleTable = People.GetPeopleSummary();
            dgvPeople.DataSource = _PeopleTable;
        }
        public frmPeople()
        {
            InitializeComponent();

            _LoadPeople();

            cmbFilter.DataSource = People.GetSearchFilters();

            cmbFilter.SelectedIndex = 0;

        }
        private void Search(object sender, EventArgs e)
        {

            if (cmbFilter.SelectedItem == null) return;

                _PeopleTable.DefaultView.RowFilter = $"CONVERT([{cmbFilter.SelectedItem.ToString()}], 'System.String'" +
                    $") LIKE" +
                    $" '%{txtSearch.Text}%'";

                dgvPeople.DataSource = _PeopleTable;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPersonCard personCard = new frmPersonCard(SelectedPersonID))
            {
                personCard.ShowDialog();
            }
        }
        private void AddPerson(object sender, EventArgs e)
        {
            using (frmAddEditPerson frm = new frmAddEditPerson())
            {

                frm.DataBack += frmAddEditPerson_DataBack;
                frm.ShowDialog();

            }
        }

        private void EditPerson(object sender, EventArgs e)
        {
            using (frmAddEditPerson frm = new frmAddEditPerson(SelectedPersonID))
            {
                frm.DataBack += frmAddEditPerson_DataBack;
                frm.ShowDialog();
            }
        }

        private void DeletePerson(object sender, EventArgs e)
        {
            if (People.IsExists(SelectedPersonID))
            {
                string FullName = dgvPeople.CurrentRow.Cells["First Name"].Value.ToString()
                    + " " + dgvPeople.CurrentRow.Cells["Second Name"].Value.ToString()
                    + " " + dgvPeople.CurrentRow.Cells["Last Name"].Value.ToString();

                string ID = dgvPeople.CurrentRow.Cells["Person ID"].Value.ToString();

                string message = $"Are you sure you want to delete " +
                    $"{FullName}\n the owner of the ID: {ID}";

                if (KryptonMessageBox.Show(message, "", KryptonMessageBoxButtons.YesNo,
                    KryptonMessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (People.DeleteFromPeopleByPersonID(SelectedPersonID))
                    { 
                        _PeopleTable.Rows.Find(SelectedPersonID).Delete();
                    }
                }
            }
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (frmPersonCard card = new frmPersonCard(SelectedPersonID))
            {
                card.ShowDialog();
            }
        }

        private void frmAddEditPerson_DataBack(object sender, People Person)
        {

            DataRow rowToEdit = _PeopleTable.Rows.Find(Person.PersonID);

            if (rowToEdit != null)
            {
                dgvPeopleEditPerson(Person,  rowToEdit);
            }
            else
            {
                dgvPeopleAddPerson(Person);
            }
        }

        private void dgvPeopleAddPerson(People Person)
        {
            DataRow row = _PeopleTable.NewRow();

            row["Person ID"] = Person.PersonID;
            row["National No."] = Person.NationalNo;
            row["First name"] = Person.FirstName;
            row["Second Name"] = Person.SecondName;
            row["Third Name"] = Person.ThirdName;
            row["Last Name"] = Person.LastName;

            row["Birth Date"] = Person.DateOfBirth.ToString("dd/MM/yyyy");
            row["Gender"] = (Person.Gendor == 0) ? "Male" : "Female";

            row["Nationality"] = Person.CountryInfo.CountryName;

            row["Phone Number"] = Person.Phone;
            row["Email"] = Person.Email;

            _PeopleTable.Rows.Add(row);

        }
        private void dgvPeopleEditPerson(People Person, DataRow rowToEdit)
        {

            if (rowToEdit != null)
            {

                rowToEdit["National No."] = Person.NationalNo;
                rowToEdit["First name"] = Person.FirstName;
                rowToEdit["Second Name"] = Person.SecondName;
                rowToEdit["Third Name"] = Person.ThirdName;
                rowToEdit["Last Name"] = Person.LastName;

                rowToEdit["Birth Date"] = Person.DateOfBirth.ToString("dd/MM/yyyy");

                rowToEdit["Gender"] = (Person.Gendor == 0) ? "Male" : "Female";

                rowToEdit["Nationality"] = Person.CountryInfo.CountryName;

                rowToEdit["Phone Number"] = Person.Phone;
                rowToEdit["Email"] = Person.Email;

            }
        }
    }
}
