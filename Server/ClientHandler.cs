using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientHandler
    {
        bool end = false;
        private Socket socket;
        CommunicationHelper helper;

        public ClientHandler(Socket socket) 
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (!end)
                {
                    Request request = helper.receive<Request>(); //(Request)formatter.Deserialize(stream);
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException error)
            {
                Debug.WriteLine(">>>>> ", error.ToString());
            }
            finally
            {
                CloseConnection();
                // TODO remove client from client handler list
            }
        }

        public Response CreateResponse(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.LoginUser((User)request.RequestObject);
                        break;
                    case Operation.GetAllProducts:
                        response.Result = Controller.Instance.GetAllProducts();
                        break;
                    case Operation.EndConnection:
                        end = true;
                        break;
                }
                
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>>>> ", e.ToString());
                response.IsSuccess = false;
                response.Message = e.ToString();
            }

            return response;
        }

        internal void CloseConnection()
        {
            if (socket != null)
            {
                end = true;
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
            }
        }
    }
}
