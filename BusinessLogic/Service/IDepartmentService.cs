using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IDepartmentService
    {
        List<Department> Get();
        List<Department> GetSearch(string values);
        Department Get(int Id);
        bool Insert(DepartmentVM departmentVM);
        bool Update(int id, DepartmentVM departmentVM);
        bool Delete(int id);
    }
}
