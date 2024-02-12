using ApplicationLogic;
using Domain;
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
            cbMeasurementUnit.DataSource = Enum.GetValues(typeof(MeasurementUnit));
            cbMeasurementUnit.SelectedItem = null;
        }

        private void setMeasurementUnits()
        {
            cbManufacturer.DataSource = Controller.Instance.GetManufactures();
            cbManufacturer.SelectedItem = null;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO add validation for this
            if (
                tbName.Text == ""
                || tbDescription.Text == ""
                || cbMeasurementUnit.SelectedItem == null
                || cbManufacturer.SelectedItem == null
                || !double.TryParse(tbPrice.Text, out _)
                || !int.TryParse(tbId.Text, out _)
                )
            {
                lblRequired.Visible = true; // TODO update message to indicate wrong walue
                return;
            }
            Product newProduct = new Product();

            newProduct.Id = int.Parse(tbId.Text);
            newProduct.Name = tbName.Text;
            newProduct.Description = tbDescription.Text;
            newProduct.Price = Double.Parse(tbPrice.Text);
            newProduct.MeasurementUnit = (MeasurementUnit)cbMeasurementUnit.SelectedItem;
            newProduct.Manufacturer = (Manufacturer)cbManufacturer.SelectedItem;
            

            Controller.Instance.addProduct(newProduct);
        }
    }
}
