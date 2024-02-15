using Base_form.Exceptions;
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
            while (true) // If anythiong breaks restart, unless dialog result is cancel - that  means that user intentionaly closed it
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    DialogResult frmLoginDialogResult = frmLogin.ShowDialog();
                    frmLogin.Dispose();

                    if (frmLoginDialogResult == DialogResult.OK)
                    {
                        FrmMain frmMain = new FrmMain();
                        Application.Run(frmMain);
                    }
                    if (frmLoginDialogResult == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException sce)
                {
                    MessageBox.Show("Serrver disconected.", sce.Message);
                } 
            }
        }
    }
}
