using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using BLL;
using DrivingVehicleLicenseDepartment.Forms;

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmUsers : KryptonForm
    {
        private DataTable _UsersTable = new DataTable();

        private int SelectedUserID
        {
            get
            {
                return Convert.ToInt32(
                    dgvUsers.CurrentRow.Cells["User ID"].Value
                    );
            }
        }
        public frmUsers()
        {
            InitializeComponent();
            _UsersTable = Users.GetUsersSummary();
            dgvUsers.DataSource = _UsersTable;
            cmbFilter.DataSource = Users.GetSearchFilters();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserCard card = new frmUserCard(SelectedUserID); 
            card.ShowDialog();
        }


        private void Search(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null) return;

            _UsersTable.DefaultView.RowFilter = $"CONVERT([{cmbFilter.SelectedItem.ToString()}]," +
                $" 'System.String') LIKE '%{txtSearch.Text.Trim()}%'";

            dgvUsers.DataSource = _UsersTable;
        }
        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmUserCard card = new frmUserCard(SelectedUserID))
            {
                card.ShowDialog();
            }
        }
        private void AddUser(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser())
            {
                frm.DataBack += frmAddEditUser_DataBack;
                frm.ShowDialog();
            }
        }

        private void EditUser(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser(SelectedUserID))
            {
                frm.DataBack += frmAddEditUser_DataBack;
                frm.ShowDialog();
            }
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            if (Users.IsExists(SelectedUserID))
            {
                string FullName = dgvUsers.CurrentRow.Cells["Full name"].Value.ToString();

                string UserID = dgvUsers.CurrentRow.Cells["User ID"].Value.ToString();

                string message = $"Are you sure you want to delete " +
                    $"{FullName}\n the owner of the user ID: {UserID}";

                if (KryptonMessageBox.Show(message, "", KryptonMessageBoxButtons.YesNo,
                    KryptonMessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Users.DeleteFromUsersByUserID(SelectedUserID))
                    {
                        _UsersTable.Rows.Find(SelectedUserID).Delete();
                    }
                }
            }
        }

        private void frmAddEditUser_DataBack(object sender, Users user)
        {

            DataRow rowToEdit = _UsersTable.Rows.Find(user.UserID);

            if (rowToEdit != null)
            {
                dgvUsersEditUser(user, rowToEdit);
            }
            else
            {
                dgvUsersAddUser(user);
            }

        }



        private void dgvUsersAddUser(Users user)
        {
            DataRow row = _UsersTable.NewRow();

            People Person = user.PersonInfo;

            row["Person ID"] = user.PersonID;
            row["User ID"] = user.UserID;

            row["Full name"] = Person.FullName;
            row["Username"] = user.UserName;

            row["Is active"] = user.IsActive;

            _UsersTable.Rows.Add(row);
        }

        private void dgvUsersEditUser(Users user, DataRow rowToEdit)
        {

            if (rowToEdit != null)
            {

            People Person = user.PersonInfo;

                rowToEdit["Person ID"] = user.PersonID;
                rowToEdit["User ID"] = user.UserID;

                rowToEdit["Full name"] = Person.FullName;
                rowToEdit["Username"] = user.UserName;

                rowToEdit["Is active"] = user.IsActive;

            }
        }
    }
}
