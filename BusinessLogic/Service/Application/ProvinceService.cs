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
    public class ProvinceService : IProvinceService
    {
        IProvinceRepository iProvinceRepository = new ProvinceRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iProvinceRepository.Delete(id);
        }

        public List<Province> Get()
        {
            return iProvinceRepository.Get();
        }

        public Province Get(int Id)
        {
            return iProvinceRepository.Get(Id);
        }

        public List<Province> GetSearch(string values)
        {
            return iProvinceRepository.GetSearch(values);
        }

        public bool Insert(ProvinceVM provinceVM)
        {
            if (string.IsNullOrWhiteSpace(provinceVM.Name))
            {
                return status;
            }
            else
            {
                return iProvinceRepository.Insert(provinceVM);
            }
        }

        public bool Update(int id, ProvinceVM provinceVM)
        {
            return iProvinceRepository.Update(id, provinceVM);
        }
    }
}
