using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IPositionService
    {
        List<Position> Get();
        List<Position> GetSearch(string values);
        Position Get(int Id);
        bool Insert(PositionVM positionVM);
        bool Update(int id, PositionVM positionVM);
        bool Delete(int id);
    }
}
