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

        public bool CekLogin(string email, string password)
        {
            bool cek = false;
            //var temp = myContext.Employees.Include("TB_M_User").Where(x => (x.Email.Contains(email) && x.User.Password.Contains(password))).SingleOrDefault();
            var temp1 = myContext.Employees.Where(x => x.Email == email).SingleOrDefault();
            var temp2 = myContext.Users.Where(x => x.Password == password).SingleOrDefault();

            try
            {
                if(temp1.Email == email && temp2.Password == password)
                {
                    cek = true;
                }
                else
                {
                    cek = false;
                }
            }
            catch (Exception ex)
            {
                cek = false;
                ex.GetBaseException();
            }
            return cek;
        }

        //public List<Employee> GetEmail(string email)
        //{
        //    var get = myContext.Employees.Where(x => (x.Email.Contains(email))).ToList();
        //    return get;
        //}

        //public List<User> GetPass(string password)
        //{
        //    var get = myContext.Users.Where(x => (x.Password.Contains(password))).ToList();
        //    return get;
        //}
    }
}
