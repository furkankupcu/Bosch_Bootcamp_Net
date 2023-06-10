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
    public class SubcomponentManager : ISubcomponentService
    {
        private readonly BBContext bBContext;

        public SubcomponentManager(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddSubcomponent(Subcomponent subcomponent)
        {
            var result = bBContext.BB_Subcomponent.Any(s => s.SubcomponentID == subcomponent.SubcomponentID);
            if(!result)
            {
                try
                {
                    bBContext.BB_Subcomponent.Add(subcomponent);
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

        public bool DeleteSubcomponent(Subcomponent subcomponent)
        {
            var result = bBContext.BB_Subcomponent.Any(s => s.SubcomponentID == subcomponent.SubcomponentID);
            if (result)
            {
                try
                {
                    bBContext.BB_Subcomponent.Remove(subcomponent);
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


        public bool UpdateSubcomponent(Subcomponent subcomponent)
        {
            var result = bBContext.BB_Subcomponent.Any(s =>s.SubcomponentID  == subcomponent.SubcomponentID);
            if (result)
            {
                try
                {
                    bBContext.Update(subcomponent);
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


        public List<Subcomponent> GetAllSubcomponents()
        {
            return bBContext.BB_Subcomponent.ToList();
        }

        public Subcomponent GetSubcomponentById(int id)
        {
            return bBContext.BB_Subcomponent.Where(X => X.SubcomponentID== id).FirstOrDefault();
        }

        public int GetSubcomponentCount(int id)
        {
            return bBContext.BB_Subcomponent.Count();
        }

        public List<int> GetNotAddedSubcomponents()
        {
            return (from e in bBContext.BB_Subcomponent select e.SubcomponentID).Except(from m in bBContext.BB_StationProcess select m.SubcomponentID).ToList();
        }
    }
}
