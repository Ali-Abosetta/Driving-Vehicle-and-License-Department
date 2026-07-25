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
    public partial class frmLicenseHistory : KryptonForm
    {

        private DataTable _LocalLicensesTable = new DataTable();
        private DataTable _InternationalLicenseTable = new DataTable();

        private People _Person = new People();
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();

            _LocalLicensesTable = BLL.Licenses.GetDriverLocalLicensesSummary(PersonID);
            dgvLocalLicenses.DataSource = _LocalLicensesTable;

            dgvLocalLicenses.Columns["License class"].Width = 250;
        }
        public frmLicenseHistory(BLL.People Person)
        {
            InitializeComponent();

            _Person = Person;
            ctrlPersonCardEditable1.Person = Person;

            _LocalLicensesTable = BLL.Licenses.GetDriverLocalLicensesSummary(Person.PersonID);
            dgvLocalLicenses.DataSource = _LocalLicensesTable;

            dgvLocalLicenses.Columns["License class"].Width = 250;
        }
   }
}
