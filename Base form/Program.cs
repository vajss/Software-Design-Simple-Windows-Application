using MainFormUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmLogin = new FrmLogin(); 
            DialogResult frmLoginDialogResult = frmLogin.ShowDialog();

            if(frmLoginDialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());

            }
        }
    }
}
