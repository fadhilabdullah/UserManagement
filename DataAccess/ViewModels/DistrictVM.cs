﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DistrictVM
    {
        public DistrictVM(string name) 
        {
            this.Name = name;
        }

        public DistrictVM() { }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Regency_Id { get; set; }
    }
}
