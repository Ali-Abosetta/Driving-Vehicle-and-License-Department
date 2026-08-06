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

        private BLL.People _Person = new BLL.People();
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();

            _Person = BLL.People.Find(PersonID);
            ctrlPersonCardEditable1.Person = _Person;
            _LocalLicensesTable = BLL.Licenses.GetDriverLocalLicensesSummary(PersonID);
            dgvLocalLicenses.DataSource = _LocalLicensesTable;
            dgvLocalLicenses.Columns["License class"].Width = 250;

            _InternationalLicenseTable = BLL.InternationalLicenses.GetDriverInternationalLicensesSummary(PersonID);
            dgvInternationalLicenses.DataSource= _InternationalLicenseTable;
        }
        public frmLicenseHistory(BLL.People Person)
        {
            InitializeComponent();

            _Person = Person;
            ctrlPersonCardEditable1.Person = Person;

            _LocalLicensesTable = BLL.Licenses.GetDriverLocalLicensesSummary(Person.PersonID);
            dgvLocalLicenses.DataSource = _LocalLicensesTable;
            dgvLocalLicenses.Columns["License class"].Width = 250;

            _InternationalLicenseTable = BLL.InternationalLicenses.GetDriverInternationalLicensesSummary(Person.PersonID);
            dgvInternationalLicenses.DataSource = _InternationalLicenseTable;
        }

    }
}
