using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class EmployeeRepository : IEmployeeRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            var delete = Get(id);
            delete.Delete();
            myContext.Entry(delete).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public List<Employee> Get()
        {
            var get = myContext.Employees.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            var get = myContext.Employees.SingleOrDefault(x => x.Id == id && x.IsDelete == false);
            return get;
        }

        public List<Employee> GetSearch(string values)
        {
            var get = myContext.Employees.Where(x => (x.Name.Contains(values) ||
                   x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            var push = new Employee(employeeVM);
            var getDepartmentId = myContext.Departments.Find(employeeVM.Department_Id);
            push.Department = getDepartmentId;
            var getUserId = myContext.Users.Find(employeeVM.User_Id);
            push.User = getUserId;
            var getPositionId = myContext.Positions.Find(employeeVM.Position_Id);
            push.Position = getPositionId;
            var getVillageId = myContext.Villages.Find(employeeVM.Village_Id);
            push.Village = getVillageId;
            myContext.Employees.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            var put = Get(id);
            var getDepartmentId = myContext.Departments.Find(employeeVM.Department_Id);
            put.Department = getDepartmentId;
            var getUserId = myContext.Users.Find(employeeVM.User_Id);
            put.User = getUserId;
            var getPositionId = myContext.Positions.Find(employeeVM.Position_Id);
            put.Position = getPositionId;
            var getVillageId = myContext.Villages.Find(employeeVM.Village_Id);
            put.Village = getVillageId;
            put.Update(employeeVM);
            myContext.Entry(put).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
