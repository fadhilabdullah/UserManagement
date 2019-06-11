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
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository iDepartmentRepository = new DepartmentRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iDepartmentRepository.Delete(id);
        }

        public List<Department> Get()
        {
            return iDepartmentRepository.Get();
        }

        public Department Get(int Id)
        {
            return iDepartmentRepository.Get(Id);
        }

        public List<Department> GetSearch(string values)
        {
            return iDepartmentRepository.GetSearch(values);
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            if (string.IsNullOrWhiteSpace(departmentVM.Name))
            {
                return status;
            }
            else
            {
                return iDepartmentRepository.Insert(departmentVM);
            }
        }

        public bool Update(int id, DepartmentVM departmentVM)
        {
            return iDepartmentRepository.Update(id, departmentVM);
        }
    }
}
