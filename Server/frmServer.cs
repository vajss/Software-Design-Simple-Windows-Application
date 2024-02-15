using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        private Server server;
        private bool serverRunning = false;
        ToggleButton btnToggle = new ToggleButton();

        public frmServer()
        {
            InitializeComponent();
        }

        private void StartServer()
        {
            server = new Server();
            
            if(server.Start()){
                Thread thread = new Thread(server.Listen);
                thread.IsBackground = true;
                thread.Start();
            }
            
        }

        private void StopServer()
        {
            server?.Stop();
            server = null;
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            serverRunning = !serverRunning;
            if (serverRunning)
            {
                btnToggle.BackColor = Color.PaleGreen;
                btnToggle.TextAlign = ContentAlignment.MiddleRight;
                StartServer();
            }
            else
            {
                btnToggle.BackColor = SystemColors.ControlDark;
                btnToggle.TextAlign = ContentAlignment.MiddleLeft;
                StopServer();
            }
        }
    }
}
