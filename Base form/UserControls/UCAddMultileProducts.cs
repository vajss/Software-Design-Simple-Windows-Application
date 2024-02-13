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
    public partial class UCAddMultileProducts : UserControl
    {
        private BindingList<Product> productsInTable = new BindingList<Product>();

        public UCAddMultileProducts()
        {
            InitializeComponent();
            dgvMultipleProducts.DataSource = productsInTable;
            dgvMultipleProducts.Columns["Manufacturer"].Visible = false;
            dgvMultipleProducts.Columns["Id"].Visible = false;
            dgvMultipleProducts.Columns["MeasurementUnit"].Visible = false;
            dgvMultipleProducts.Columns["DateCreated"].Visible = false;


            DataGridViewComboBoxColumn manufacturersCB = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Manufacturer",
                DataSource = Controller.Instance.GetManufactures(),
                DataPropertyName = "Manufacturer", // Property in binding lists class that we want to attach this column to
                ValueMember = "Self", // Reference to Manufacturers class 'this'
                DisplayMember = "Name", // Display name - assign property of class that contains objects name
            };

            DataGridViewComboBoxColumn measurementUnitCB = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Unit",
                DataSource = Controller.Instance.GetMeasurementUnits(),
                DataPropertyName = "MeasurementUnit",
            };
            
            dgvMultipleProducts.Columns.Add(measurementUnitCB);
            dgvMultipleProducts.Columns.Add(manufacturersCB);
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            try
            {

                Controller.Instance.AddMultipleProduct(productsInTable.ToList());
            }
            catch (Exception)
            {
                // TODO add lable that indicates something failed
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMultipleProducts.SelectedRows)
            {
                Product product = (Product)row.DataBoundItem;
                productsInTable.Remove(product);
            }
            
        }
    }
}
