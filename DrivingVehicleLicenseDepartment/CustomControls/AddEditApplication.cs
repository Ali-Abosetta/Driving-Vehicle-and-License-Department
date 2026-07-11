using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingVehicleLicenseDepartment.CustomControls
{
    public partial class AddEditApplication : UserControl
    {
        public AddEditApplication()
        {
            InitializeComponent();
        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {
            cmbClasses.SelectedIndex = 2;
        }
    }
}
