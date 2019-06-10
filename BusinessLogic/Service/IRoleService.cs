using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IRoleService
    {
        List<Role> Get();
        List<Role> GetSearch(string values);
        Role Get(int Id);
        bool Insert(RoleVM roleVM);
        bool Update(int id, RoleVM roleVM);
        bool Delete(int id);
    }
}
