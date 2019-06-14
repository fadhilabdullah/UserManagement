using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public EmployeeVM(string name, string Address, string gender, string religion, string marital_status, 
            string phone_number, string employement_status, string email, double salary, int department_id, 
            int village_id, int position_id) 
        {
            this.Name = name;
            this.Address = Address;
            this.Gender = gender;
            this.Religion = religion;
            this.Marital_Status = marital_status;
            this.Phone_Number = phone_number;
            this.Employement_Status = employement_status;
            this.Email = email;
            this.Salary = salary;
            this.Department_Id = department_id;
            this.Village_Id = village_id;
            this.Position_Id = position_id;
        }

        public EmployeeVM() { }

        public void Update(int id, string name, string Address, string gender, string religion, string marital_status,
            string phone_number, string employement_status, string email, double salary, int department_id,
            int village_id, int position_id)
        {
            this.Id = id;
            this.Name = name;
            this.Address = Address;
            this.Gender = gender;
            this.Religion = religion;
            this.Marital_Status = marital_status;
            this.Phone_Number = phone_number;
            this.Employement_Status = employement_status;
            this.Email = email;
            this.Salary = salary;
            this.Department_Id = department_id;
            this.Village_Id = village_id;
            this.Position_Id = position_id;
        }

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

        public int Department_Id { get; set; }
        public int Village_Id { get; set; }
        public int Position_Id { get; set; }
    }
}
