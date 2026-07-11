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

namespace DrivingVehicleLicenseDepartment
{
    public partial class frmPersonCard : KryptonForm
    {
        public frmPersonCard(int PersonID)
        {
            InitializeComponent();

            ctrlPersonCardEditable1.Person = People.Find(PersonID);
            ctrlPersonCardEditable1.Enabled = false;

            ctrlPersonCardEditable1.lblPicture.Visible = false;

            if(ctrlPersonCardEditable1.Person.Gendor == 0)
            {
                ctrlPersonCardEditable1.rbFemale.Visible = false;
                ctrlPersonCardEditable1.rbMale.Visible = true;
            }
            else
            {
                ctrlPersonCardEditable1.rbMale.Visible = false;
                ctrlPersonCardEditable1.rbFemale.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
