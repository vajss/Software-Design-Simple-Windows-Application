﻿using ApplicationLogic;
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
    public partial class UCInvoice : UserControl
    {
        public UCInvoice()
        {
            InitializeComponent();

            tbUser.Text = $"{Controller.Instance.CurrentUser.Name} {Controller.Instance.CurrentUser.LastName}";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
