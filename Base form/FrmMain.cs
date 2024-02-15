using ApplicationLogic;
using Base_form;
using Base_form.ServerCommunication;
using Base_form.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ChangePanel(new UCProducts());
            this.Text = $"Welcome {Controller.Instance.CurrentUser.Name}";
        }

        private void ChangePanel(UserControl control)
        {
            pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(control);
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCAddProduct());
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCProducts());
        }

        private void addMultipleProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCAddMultileProducts());
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCInvoice());
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Communication.Instance.Close();
            }
            catch (IOException ioe)
            {
                Debug.WriteLine(ioe.ToString());
            }
        }
    }
}
