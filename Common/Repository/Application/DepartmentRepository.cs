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
    public class DepartmentRepository : IDepartmentRepository
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
                status = true;
            return status;
        }

        public List<Department> Get()
        {
            var get = myContext.Departments.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Department Get(int id)
        {
            var get = myContext.Departments.Find(id);
            return get;
        }

        public List<Department> GetSearch(string values)
        {
            var get = myContext.Departments.Where(x => (x.Name.Contains(values) ||
                x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            var push = new Department(departmentVM);
            myContext.Departments.Add(push);
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

        public bool Update(int id, DepartmentVM departmentVM)
        {
            var put = Get(id);
            put.Update(departmentVM);
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
