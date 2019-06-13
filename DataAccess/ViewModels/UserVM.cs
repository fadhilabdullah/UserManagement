﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserVM
    {
        public UserVM(string name, string password)
        {
            this.Password = password;
        }

        public UserVM() { }

        public int Id { get; set; }
        public string Password { get; set; }
        public string LoginStatus { get; set; }

        public int Employee_Id { get; set; }
    }
}
