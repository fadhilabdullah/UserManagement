using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IProvinceService
    {
        List<Province> Get();
        List<Province> GetSearch(string values);
        Province Get(int Id);
        bool Insert(ProvinceVM provinceVM);
        bool Update(int id, ProvinceVM provinceVM);
        bool Delete(int id);
    }
}
