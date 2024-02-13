using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    public class UserDataProvider
    {
        public UserDataProvider() {}

        public List<User> GetUsers()
        {
            Broker broker = new Broker();
            try
            {
                broker.OpenConnection();
                return broker.GetAllUsers();
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
