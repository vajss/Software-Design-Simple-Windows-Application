using Base_form.Exceptions;
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

namespace Base_form.ServerCommunication
{
    public class Communication
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Communication instance;

        public static Communication Instance { 
            get
            {
                if(instance == null)
                {
                    instance = new Communication();
                    return instance;
                }
                return instance;
            }
        }

        private Communication(){}

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            helper = new CommunicationHelper(socket);
        }

        private T GetResult<T>()
        {
            Response response = helper.receive<Response>();
            if (response != null && response.IsSuccess)
            {
                return (T)response.Result;
            }
            else
            {
                throw new Exception(response.Message);
            }
        }

        public void SendRequest(Operation operation, object requestData = null ) {
            try
            {
                Request request = new Request()
                {
                    RequestObject = requestData,
                    Operation = operation
                };
                helper.Send(request);
            }
            catch (IOException ioe)
            {
                throw new ServerCommunicationException(ioe.Message); // bace ServerCommunicationException al ga ne vata izgleda
            }
        }

        public User Login(User user)
        {
            SendRequest(Operation.Login, user);
            return GetResult<User>();
        }
        // TODO do same for other methods that read directly from db

        public void Close()
        {
            if (socket == null) return;
            SendRequest(Operation.EndConnection);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        internal List<Product> GetAllProducts()
        {
            SendRequest(Operation.GetAllProducts);
            return GetResult<List<Product>>();
        }
    }
}
