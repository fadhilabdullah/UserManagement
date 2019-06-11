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
    public class DistrictService : IDistrictService
    {
        IDistrictRepository iDistrictRepository = new DistrictRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iDistrictRepository.Delete(id);
        }

        public List<District> Get()
        {
            return iDistrictRepository.Get();
        }

        public District Get(int Id)
        {
            return iDistrictRepository.Get(Id);
        }

        public List<District> GetSearch(string values)
        {
            return iDistrictRepository.GetSearch(values);
        }

        public bool Insert(DistrictVM districtVM)
        {
            if (string.IsNullOrWhiteSpace(districtVM.Name))
            {
                return status;
            }
            else
            {
                return iDistrictRepository.Insert(districtVM);
            }
        }

        public bool Update(int id, DistrictVM districtVM)
        {
            return iDistrictRepository.Update(id, districtVM);
        }
    }
}
