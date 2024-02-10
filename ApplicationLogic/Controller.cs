using DataProviders;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;

        public static Controller Instance { 
            get { 
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            } 
        }
        private Controller() { }

        public User CurrentUser { get; private set; }

        UserDataProvider userDataSource = new UserDataProvider();

        public User LoginUser(User loginUser)
        {
            if (loginUser == null)
            {
                throw new ArgumentNullException();
            }

            List<User> users = userDataSource.GetUsers();
            foreach (User user in users)
            {
                if(user.Username == loginUser.Username && user.Password == user.Password)
                {
                    CurrentUser = user;
                    return user;
                }
            }

            return null;
        }

    }
}
