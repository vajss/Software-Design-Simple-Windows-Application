using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        private Socket socket;
        List<ClientHandler> clientHandlers = new List<ClientHandler>();
        public Server()
        { 
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {
            try
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(iPEndPoint);
                socket.Listen(1000);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>" + e.Message);
                return false;
            }
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = socket.Accept();
                    ClientHandler clientHandler = new ClientHandler(clientSocket, clientHandlers);
                    clientHandlers.Add(clientHandler);
                    clientHandler.ClientSignOff += HandleClientSignOff;
                    Thread handleRequestThread = new Thread(clientHandler.HandleRequest);
                    handleRequestThread.IsBackground = true;
                    handleRequestThread.Start();
                    // clientHandler.HandleRequest();
                }
            }
            catch (SocketException e)
            {
                Debug.WriteLine(">>>>> ", e.Message);
            }
        }

        public void HandleClientSignOff(object sender, EventArgs args)
        {
            clientHandlers.Remove((ClientHandler)sender);
        }

        public void Stop()
        {
            socket.Close();
            foreach (ClientHandler clientHandler in clientHandlers.ToList())
            {
                clientHandler.CloseConnection();
            }
        }
    }
}
