﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DepartmentVM
    {
        public DepartmentVM(string name)
        {
            this.Name = name;
        }

        public DepartmentVM() { }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
