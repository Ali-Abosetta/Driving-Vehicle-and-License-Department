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
using DrivingVehicleLicenseDepartment.CustomControls;

namespace DrivingVehicleLicenseDepartment.Forms.People
{
    public partial class frmPersonCard : KryptonForm
    {
        public frmPersonCard(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard1.Person = BLL.People.Find(PersonID);
        }
        public frmPersonCard(BLL.People person)
        {
            InitializeComponent();
            ctrlPersonCard1.Person = person;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
