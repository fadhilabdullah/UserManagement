using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IPositionRepository
    {
        List<Position> GetSearch(string values);
        List<Position> Get();
        Position Get(int id);
        bool Insert(PositionVM positionVM);
        bool Update(int id, PositionVM positionVM);
        bool Delete(int id);
    }
}
