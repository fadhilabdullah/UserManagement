using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ILoginRepository
    {
        //Employee GetEmail(int id);
        //User GetPass(int id);

        List<Employee> GetEmail(string email);
        List<User> GetPass(string password);
    }
}
