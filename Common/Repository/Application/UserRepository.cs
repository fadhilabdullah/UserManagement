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
    public class UserRepository : IUserRepository
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

        public List<User> Get()
        {
            var get = myContext.Users.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public User Get(int id)
        {
            var get = myContext.Users.Find(id);
            return get;
        }

        public List<User> GetSearch(string values)
        {
            var get = myContext.Users.Where(x => x.Id.ToString().Contains(values) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(UserVM userVM)
        {
            var push = new User(userVM);
            myContext.Users.Add(push);
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

        public bool Update(int id, UserVM userVM)
        {
            var put = Get(id);
            put.Update(userVM);
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
