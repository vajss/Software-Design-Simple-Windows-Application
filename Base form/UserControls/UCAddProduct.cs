using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_form.UserControls
{
    public partial class UCAddProduct : UserControl
    {
        public UCAddProduct()
        {
            InitializeComponent();
            this.setMeasurementUnits();
            this.setManufacturers();
        }

        private void setManufacturers()
        {
            cbManufacturer.DataSource = new string[] { "Kg", "Meter", "Liters" };
            cbManufacturer.SelectedItem = null;
        }

        private void setMeasurementUnits()
        {
            cbMeasurementUnit.DataSource = new string[] { "Delta", "Dehlhaze", "Lidl" };
            cbMeasurementUnit.SelectedItem = null;
        }

        private void cbMeasurementUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMeasurementUnit.SelectedItem != null)
            {
                string cbMeascbMeasurementUnit = cbMeasurementUnit.SelectedItem.ToString();
            }
        }
    }
}
