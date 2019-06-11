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
    public class VillageService : IVillageService
    {
        IVillageRepository iVillageRepository = new VillageRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iVillageRepository.Delete(id);
        }

        public List<Village> Get()
        {
            return iVillageRepository.Get();
        }

        public Village Get(int Id)
        {
            return iVillageRepository.Get(Id);
        }

        public List<Village> GetSearch(string values)
        {
            return iVillageRepository.GetSearch(values);
        }

        public bool Insert(VillageVM villageVM)
        {
            if (string.IsNullOrWhiteSpace(villageVM.Name))
            {
                return status;
            }
            else
            {
                return iVillageRepository.Insert(villageVM);
            }
        }

        public bool Update(int id, VillageVM villageVM)
        {
            return iVillageRepository.Update(id, villageVM);
        }
    }
}
