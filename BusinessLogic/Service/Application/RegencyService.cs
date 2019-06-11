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
    public class RegencyService : IRegencyService
    {
        IRegencyRepository iRegencyRepository = new RegencyRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iRegencyRepository.Delete(id);
        }

        public List<Regency> Get()
        {
            return iRegencyRepository.Get();
        }

        public Regency Get(int Id)
        {
            return iRegencyRepository.Get(Id);
        }

        public List<Regency> GetSearch(string values)
        {
            return iRegencyRepository.GetSearch(values);
        }

        public bool Insert(RegencyVM regencyVM)
        {
            if (string.IsNullOrWhiteSpace(regencyVM.Name))
            {
                return status;
            }
            else
            {
                return iRegencyRepository.Insert(regencyVM);
            }
        }

        public bool Update(int id, RegencyVM regencyVM)
        {
            return iRegencyRepository.Update(id, regencyVM);
        }
    }
}
