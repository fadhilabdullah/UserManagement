using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IVillageService
    {
        List<Village> Get();
        List<Village> GetSearch(string values);
        Village Get(int Id);
        bool Insert(VillageVM villageVM);
        bool Update(int id, VillageVM villageVM);
        bool Delete(int id);
    }
}
