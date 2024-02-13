using ApplicationLogic;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_form.UserControls
{
    public partial class UCInvoice : UserControl
    {
        BindingList<InvoiceItem> invoiceItems = new BindingList<InvoiceItem>();

        public UCInvoice()
        {
            InitializeComponent();
            this.initalizeProperties();
            tbDate.Text = "12.11.2025 14:20"; // to not enter it every time while testing
        }
        
        private void initalizeProperties()
        {
            tbUser.Text = $"{Controller.Instance.CurrentUser.Name} {Controller.Instance.CurrentUser.LastName}";
            cbProduct.DataSource = Controller.Instance.GetAllProducts();
            cbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvInvoiceItems.DataSource = invoiceItems;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try // TODO do proper validation here
            {
                InvoiceItem item = new InvoiceItem()
                {
                    Sn = invoiceItems.Count(),
                    Product = (Product)cbProduct.SelectedItem,
                    Amount = Double.Parse(tbAmount.Text),
                    Quantity = int.Parse(tbQuantity.Text)
                };

                if (!this.UpdateItemIfAlreadyExists(item))
                {
                    invoiceItems.Add(item);
                }
                
                if (lblInvalidItem.Visible)
                {
                    lblInvalidItem.Visible = false;
                }
                this.SetTotal();
            }
            catch {
                lblInvalidItem.Visible = true;
            }
        }

        private bool UpdateItemIfAlreadyExists(InvoiceItem newItem)
        {
            foreach (InvoiceItem item in invoiceItems)
            {
                if (newItem.Product == item.Product)
                {
                    item.Quantity += newItem.Quantity;
                    item.Amount += newItem.Amount;
                    dgvInvoiceItems.Refresh();
                    return true;
                }
            }
            return false;
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbQuantity.Text) && double.TryParse(tbQuantity.Text, out _))
            {
                SetAmount();
            }
            else
            {
                if (!string.IsNullOrEmpty(tbQuantity.Text))
                {
                    lblInvalidNumber.Visible = true;
                }
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(tbQuantity.Text, out _))
            {
                lblInvalidNumber.Visible = true;
                tbAmount.Text = "";
                return;
            }
            lblInvalidNumber.Visible=false;
            SetAmount();
        }

        private void SetAmount()
        {
            try
            {
                tbAmount.Text = CalculateAmount().ToString();
                if (lblInvalidNumber.Visible)
                {
                    lblInvalidNumber.Visible = false;
                }
            }
            catch (Exception e)
            {
                lblInvalidNumber.Visible = true;
                tbAmount.Text = "";
                Console.WriteLine(e.ToString());
            }
        }

        private double CalculateAmount()
        {
            return ((double)(Double.Parse(tbQuantity.Text) * ((Product)cbProduct.SelectedItem)?.Price));
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInvoiceItems.SelectedRows)
            {
                InvoiceItem item = (InvoiceItem)row.DataBoundItem;
                invoiceItems.Remove(item); // has to have overriden equals
            }

            foreach (var item in invoiceItems.Select((value, i) => new { i, value }))
            {
                item.value.Sn = item.i;
            }
            this.SetTotal();
        }

        private void SetTotal()
        {
            tbTotal.Text = GetTotal().ToString();
        }

        private void BtnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInvoice())
            {
                lblGeneralError.Visible = true;
                return;
            };

            lblGeneralError.Visible = false;

            Invoice invoice = new Invoice()
            {
                Date = ((DateTimeOffset)DateTime.Parse(tbDate.Text)).ToUnixTimeSeconds(),
                InvoiceItems = invoiceItems.ToList(),
                User = Controller.Instance.CurrentUser,
                Total = GetTotal(),
            };

            // TODO controler save it
        }

        private bool ValidateInvoice()
        {
            // TODO Update this validation
            bool valid = true;
            if (!DateTime.TryParseExact(tbDate.Text, "dd.MM.yyyy HH:mm", null, DateTimeStyles.None ,out _))
            {
                valid = false;
            }

            return valid;
        }

        private double GetTotal()
        {
            return invoiceItems.Sum(sumItem => sumItem.Amount);
        }
        
    }
}
