using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Employee")]
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Marital_Status { get; set; }
        public string Phone_Number { get; set; }
        public string Employement_Status { get; set; }
        public string Email { get; set; }
        public Double Salary { get; set; }
        public int Department_Id { get; set; }
        public int Village_Id { get; set; }
        public int Position_Id { get; set; }

        [ForeignKey("Department_Id")]
        public virtual Department Department { get; set; }
        [ForeignKey("Village_Id")]
        public virtual Village Village { get; set; }
        [ForeignKey("Position_Id")]
        public virtual Position Position { get; set; }

        public Employee() { }

        public Employee(EmployeeVM employeeVM)
        {
            this.Name = employeeVM.Name;
            this.Address = employeeVM.Address;
            this.Gender = employeeVM.Gender;
            this.Religion = employeeVM.Religion;
            this.Marital_Status = employeeVM.Marital_Status;
            this.Phone_Number = employeeVM.Phone_Number;
            this.Employement_Status = employeeVM.Employement_Status;
            this.Email = employeeVM.Email;
            this.Salary = employeeVM.Salary;
            this.Department_Id = employeeVM.Department_Id;
            this.Village_Id = employeeVM.Village_Id;
            this.Position_Id = employeeVM.Position_Id;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public virtual void Update(EmployeeVM employeeVM)
        {
            this.Name = employeeVM.Name;
            this.Address = employeeVM.Address;
            this.Gender = employeeVM.Gender;
            this.Religion = employeeVM.Religion;
            this.Marital_Status = employeeVM.Marital_Status;
            this.Phone_Number = employeeVM.Phone_Number;
            this.Employement_Status = employeeVM.Employement_Status;
            this.Email = employeeVM.Email;
            this.Salary = employeeVM.Salary;
            this.Department_Id = employeeVM.Department_Id;            
            this.Village_Id = employeeVM.Village_Id;
            this.Position_Id = employeeVM.Position_Id;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
