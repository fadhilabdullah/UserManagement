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

        public bool CekLogin(string email, string password)
        {
            return iLogintRepository.CekLogin(email, password);
        }
    }
}
