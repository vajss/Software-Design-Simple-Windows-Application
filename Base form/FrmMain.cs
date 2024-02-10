using Base_form;
using Base_form.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCAddProduct uCAddProduct = new UCAddProduct();
            uCAddProduct.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uCAddProduct);
        }
    }
}
