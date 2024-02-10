﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProviders
{
    public class UserDataProvider
    {
        private List<User> users = new List<User>();

        public UserDataProvider() {
            users.Add(new User {
                Id = 1,
                LastName = "Aleksic",
                Name = "Vasilije",
                Username = "Vajss",
                Password = "TestPass",
            });

            users.Add(new User{
                Id = 2,
                LastName = "Ciskela",
                Name = "Ejilisav",
                Username = "Ssjav",
                Password = "TestPass",
            });
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}