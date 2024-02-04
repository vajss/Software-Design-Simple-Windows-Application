using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_form
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
            this.setMeasurementUnits();
        }

        private void setMeasurementUnits() {
            cbMeasurementUnit.DataSource = new string[] { "Kg", "Meter", "Liters"};
            cbMeasurementUnit.SelectedItem = null;
        }

        private void cbMeasurementUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMeasurementUnit.SelectedItem != null) {
                string cbMeascbMeasurementUnit = cbMeasurementUnit.SelectedItem.ToString();
                MessageBox.Show(cbMeascbMeasurementUnit);
            }
        }
    }
}
