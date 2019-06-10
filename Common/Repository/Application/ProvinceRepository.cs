using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repository.Application
{
    public class ProvinceRepository : IProvinceRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            var delete = Get(id);
            delete.Delete();
            myContext.Entry(delete).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public List<Province> Get()
        {
            var get = myContext.Provinces.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Province Get(int id)
        {
            var get = myContext.Provinces.SingleOrDefault(x => x.Id == id && x.IsDelete == false);
            return get;
        }

        public List<Province> GetSearch(string values)
        {
            var get = myContext.Provinces.Where(x => (x.Name.Contains(values) ||
                   x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(ProvinceVM provinceVM)
        {
            var push = new Province(provinceVM);
            myContext.Provinces.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public bool Update(int id, ProvinceVM provinceVM)
        {
            var put = Get(id);
            put.Update(provinceVM);
            myContext.Entry(put).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
