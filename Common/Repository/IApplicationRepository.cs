using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IApplicationRepository
    {
        List<Aplication> GetSearch(string values);
        List<Aplication> Get();
        Aplication Get(int id);
        bool Insert(ApplicationVM applicationVM);
        bool Update(int id, ApplicationVM applicationVM);
        bool Delete(int id);
    }
}
