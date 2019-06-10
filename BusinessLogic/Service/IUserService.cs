using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IUserService
    {
        List<User> Get();
        List<User> GetSearch(string values);
        User Get(int Id);
        bool Insert(UserVM userVM);
        bool Update(int id, UserVM userVM);
        bool Delete(int id);
    }
}
