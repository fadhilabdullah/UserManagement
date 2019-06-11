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
    public class PositionService : IPositionService
    {
        IPositionRepository iPositionRepository = new PositionRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iPositionRepository.Delete(id);
        }

        public List<Position> Get()
        {
            return iPositionRepository.Get();
        }

        public Position Get(int Id)
        {
            return iPositionRepository.Get(Id);
        }

        public List<Position> GetSearch(string values)
        {
            return iPositionRepository.GetSearch(values);
        }

        public bool Insert(PositionVM positionVM)
        {
            if (string.IsNullOrWhiteSpace(positionVM.Name))
            {
                return status;
            }
            else
            {
                return iPositionRepository.Insert(positionVM);
            }
        }

        public bool Update(int id, PositionVM positionVM)
        {
            return iPositionRepository.Update(id, positionVM);
        }
    }
}
