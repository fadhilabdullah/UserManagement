using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class LoginService : ILoginService
    {
        ILoginRepository iLogintRepository = new LoginRepository();

        public List<Employee> GetEmail(string email)
        {
            return iLogintRepository.GetEmail(email);
        }

        public List<User> GetPass(string password)
        {
            return iLogintRepository.GetPass(password);
        }
    }
}
