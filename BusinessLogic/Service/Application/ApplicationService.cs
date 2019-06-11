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
    public class ApplicationService : IApplicationService
    {
        IApplicationRepository iApplicationRepository = new ApplicationRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iApplicationRepository.Delete(id);
        }

        public List<Aplication> Get()
        {
            return iApplicationRepository.Get();
        }

        public Aplication Get(int Id)
        {
            return iApplicationRepository.Get(Id);
        }

        public List<Aplication> GetSearch(string values)
        {
            return iApplicationRepository.GetSearch(values);
        }

        public bool Insert(ApplicationVM aplicationVM)
        {
            if (string.IsNullOrWhiteSpace(aplicationVM.Name))
            {
                return status;
            }
            else
            {
                return iApplicationRepository.Insert(aplicationVM);
            }
        }

        public bool Update(int id, ApplicationVM aplicationVM)
        {
            return iApplicationRepository.Update(id, aplicationVM);
        }
    }
}
