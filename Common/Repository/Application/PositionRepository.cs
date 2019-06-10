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
    public class PositionRepository : IPositionRepository
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

        public List<Position> Get()
        {
            var get = myContext.Positions.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Position Get(int id)
        {
            var get = myContext.Positions.SingleOrDefault(x => x.Id == id && x.IsDelete == false);
            return get;
        }

        public List<Position> GetSearch(string values)
        {
            var get = myContext.Positions.Where(x => (x.Name.Contains(values) ||
                x.Id.ToString().Contains(values)) && x.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(PositionVM positionVM)
        {
            var push = new Position(positionVM);
            myContext.Positions.Add(push);
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

        public bool Update(int id, PositionVM positionVM)
        {
            var put = Get(id);
            put.Update(positionVM);
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
