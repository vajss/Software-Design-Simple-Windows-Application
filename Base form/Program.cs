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
            Console.WriteLine(">>>>>new frm?");

            FrmLogin frmLogin = new FrmLogin(); 
            DialogResult frmLoginDialogResult = frmLogin.ShowDialog();
            Console.WriteLine(">>>>> kada se ovo desi?");
            if(frmLoginDialogResult == DialogResult.OK)
            {
                FrmMain frmMain = new FrmMain();
                Application.Run(frmMain);

            }
        }
    }
}
