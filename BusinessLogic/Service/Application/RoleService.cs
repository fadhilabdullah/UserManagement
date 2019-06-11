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
    public class RoleService : IRoleService
    {
        IRoleRepository iRoleRepository = new RoleRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iRoleRepository.Delete(id);
        }

        public List<Role> Get()
        {
            return iRoleRepository.Get();
        }

        public Role Get(int Id)
        {
            return iRoleRepository.Get(Id);
        }

        public List<Role> GetSearch(string values)
        {
            return iRoleRepository.GetSearch(values);
        }

        public bool Insert(RoleVM roleVM)
        {
            if (string.IsNullOrWhiteSpace(roleVM.Name))
            {
                return status;
            }
            else
            {
                return iRoleRepository.Insert(roleVM);
            }
        }

        public bool Update(int id, RoleVM roleVM)
        {
            return iRoleRepository.Update(id, roleVM);
        }
    }
}
