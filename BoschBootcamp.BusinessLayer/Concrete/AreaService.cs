using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Concrete
{
    public class AreaService : IAreaService
    {
        private readonly BBContext bBContext;

        public AreaService(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddArea(Area area)
        {
            var result = bBContext.BB_Area.Any(b => b.AreaId == area.AreaId);
            if (!result)
            {
                try
                {
                    bBContext.BB_Area.Add(area);
                    bBContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteArea(Area area)
        {
            var result = bBContext.BB_Area.Any(b => b.AreaId == area.AreaId);
            if (result)
            {
                try
                {
                    bBContext.BB_Area.Remove(area);
                    bBContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Area> GetAllAreas()
        {
            return bBContext.BB_Area.ToList();
        }

        public Area GetAreaByID(int id)
        {
            return bBContext.BB_Area.Where(X => X.AreaId == id).FirstOrDefault();
        }

        public int GetAreaCount()
        {
            return bBContext.BB_Area.Count();
        }

        public bool UpdateArea(Area area)
        {
            var result = bBContext.BB_Area.Any(b => b.AreaId == area.AreaId);
            if (result)
            {
                try
                {
                    bBContext.BB_Area.Update(area);
                    bBContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
