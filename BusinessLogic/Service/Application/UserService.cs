using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class UserService : IUserService
    {
        IUserRepository iUserRepository = new UserRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iUserRepository.Delete(id);
        }

        public List<User> Get()
        {
            return iUserRepository.Get();
        }

        public User Get(int Id)
        {
            return iUserRepository.Get(Id);
        }

        public List<User> GetSearch(string values)
        {
            return iUserRepository.GetSearch(values);
        }

        public bool Insert(UserVM userVM)
        {
            if (string.IsNullOrWhiteSpace(userVM.Password))
            {
                return status;
            }
            else
            {
                return iUserRepository.Insert(userVM);
            }
        }

        public bool Update(int id, UserVM userVM)
        {
            return iUserRepository.Update(id, userVM);
        }
    }
}
