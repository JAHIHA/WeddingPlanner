﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingPlannerDomain.Entities
{//Model for User
    public class User
    {
        public int Id { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; private set; } = false;
        public User(int id, string password, string email, bool isAdmin)
        {
            Id = id;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }
        public User()
        {

        }
    }
}
