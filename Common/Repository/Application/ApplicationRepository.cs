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
    public class ApplicationRepository : IApplicationRepository
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

        public List<Aplication> Get()
        {
            var get = myContext.Applications.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Aplication Get(int id)
        {
            var get = myContext.Applications.SingleOrDefault(x => x.Id == id && x.IsDelete == false);
            return get;
        }

        public List<Aplication> GetSearch(string values)
        {
            var get = myContext.Applications.Where(x => (x.Name.Contains(values) ||
                x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ApplicationVM applicationVM)
        {
            var push = new Aplication(applicationVM);
            myContext.Applications.Add(push);
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

        public bool Update(int id, ApplicationVM applicationVM)
        {
            var put = Get(id);
            put.Update(applicationVM);
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
