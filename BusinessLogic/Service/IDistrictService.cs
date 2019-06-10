using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IDistrictService
    {
        List<District> Get();
        List<District> GetSearch(string values);
        District Get(int Id);
        bool Insert(DistrictVM districtVM);
        bool Update(int id, DistrictVM districtVM);
        bool Delete(int id);
    }
}
