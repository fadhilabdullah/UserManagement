using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Marital_Status { get; set; }
        public string Phone_Number { get; set; }
        public string Employement_Status { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public int User_Id { get; set; }
        public int Department_Id { get; set; }
        public int Role_Id { get; set; }
        public int Village_Id { get; set; }
        public int Position_Id { get; set; }
    }
}
