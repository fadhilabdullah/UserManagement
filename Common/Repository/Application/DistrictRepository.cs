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
    public class DistrictRepository : IDistrictRepository
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
                status = true;
            return status;
        }

        public List<District> Get()
        {
            var get = myContext.Districts.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public District Get(int id)
        {
            var get = myContext.Districts.Find(id);
            return get;
        }

        public List<District> GetSearch(string values)
        {
            var get = myContext.Districts.Where(x => (x.Name.Contains(values) ||
               x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(DistrictVM districtVM)
        {
            var push = new District(districtVM);
            var getRegencyId = myContext.Regencys.Find(districtVM.Regency_Id);
            push.Regency = getRegencyId;
            myContext.Districts.Add(push);
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

        public bool Update(int id, DistrictVM districtVM)
        {
            var put = Get(id);
            var getRegencyId = myContext.Regencys.Find(districtVM.Regency_Id);
            put.Regency = getRegencyId;
            put.Update(districtVM);
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
