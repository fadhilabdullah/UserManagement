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
    public class VillageRepository : IVillageRepository
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

        public List<Village> Get()
        {
            var get = myContext.Villages.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Village Get(int id)
        {
            var get = myContext.Villages.Find(id);
            return get;
        }

        public List<Village> GetSearch(string values)
        {
            var get = myContext.Villages.Where(x => (x.Name.Contains(values) ||
                x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(VillageVM villageVM)
        {
            var push = new Village(villageVM);
            var getDistrictId = myContext.Districts.Find(villageVM.District_Id);
            push.District = getDistrictId;
            myContext.Villages.Add(push);
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

        public bool Update(int id, VillageVM villageVM)
        {
            var put = Get(id);
            var getDistrictId = myContext.Districts.Find(villageVM.District_Id);
            put.District = getDistrictId;
            put.Update(villageVM);
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
