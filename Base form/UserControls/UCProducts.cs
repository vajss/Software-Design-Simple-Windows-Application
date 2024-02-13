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
    public partial class UCProducts : UserControl
    {
        int selectedId;
        public UCProducts()
        {
            InitializeComponent();
            dgvProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dgvProducts.DataSource = Controller.Instance.GetAllProducts();
            this.SetMeasurementUnits();
            this.SetManufacturers();
        }

        private void SetManufacturers()
        {
            cbMeasurementUnit.DataSource = Enum.GetValues(typeof(MeasurementUnit));
            cbMeasurementUnit.SelectedItem = null;
        }

        private void SetMeasurementUnits()
        {
            cbManufacturer.DataSource = Controller.Instance.GetManufactures();
            cbManufacturer.SelectedItem = null;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count <= 0)
            {
                return;
            }
            Product product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;

            selectedId = product.Id;
            tbDescription.Text = product.Description;
            tbName.Text = product.Name;
            tbPrice.Text = product.Price.ToString();
            cbManufacturer.SelectedItem = product.Manufacturer;
            cbMeasurementUnit.SelectedItem = product.MeasurementUnit;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO add validation for this
            if (
                tbName.Text == ""
                || tbDescription.Text == ""
                //|| !int.TryParse(selectedId),
                || cbMeasurementUnit.SelectedItem == null
                || cbManufacturer.SelectedItem == null
                || !double.TryParse(tbPrice.Text, out _)
                )
            {
                return;
            }
            Product productToUpdate = new Product();
            productToUpdate.Id = selectedId;
            productToUpdate.Name = tbName.Text;
            productToUpdate.Description = tbDescription.Text;
            productToUpdate.Price = Double.Parse(tbPrice.Text);
            productToUpdate.MeasurementUnit = (MeasurementUnit)cbMeasurementUnit.SelectedItem;
            productToUpdate.Manufacturer = (Manufacturer)cbManufacturer.SelectedItem;


            Controller.Instance.UpdateProduct(productToUpdate);
        }
    }
}
