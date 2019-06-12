using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Common.Repository.Application
{
    public class LoginRepository : ILoginRepository
    {
        MyContext myContext = new MyContext();

        public List<Employee> GetEmail(string email)
        {
            var get = myContext.Employees.Include("User").Where(x => (x.Email == (email))).ToList();
            return get;
        }

        public List<User> GetPass(string password)
        {
            var get = myContext.Users.Where(x => (x.Password == (password))).ToList();
            return get;
        }
    }
}
