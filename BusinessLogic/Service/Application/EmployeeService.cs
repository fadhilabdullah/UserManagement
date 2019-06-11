using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository iEmployeeRepository = new EmployeeRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iEmployeeRepository.Delete(id);
        }

        public List<Employee> Get()
        {
            return iEmployeeRepository.Get();
        }

        public Employee Get(int Id)
        {
            return iEmployeeRepository.Get(Id);
        }

        public List<Employee> GetSearch(string values)
        {
            return iEmployeeRepository.GetSearch(values);
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.Name))
            {
                return status;
            }
            else
            {
                return iEmployeeRepository.Insert(employeeVM);
            }
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            return iEmployeeRepository.Update(id, employeeVM);
        }
    }
}
