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
    public class InjectorService : IInjectorService
    {
        private readonly BBContext bBContext;

        public InjectorService(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddInjector(Injector injector)
        {
            var result = bBContext.BB_Injector.Any(b => b.ModelNumber == injector.ModelNumber);
            if (!result)
            {
                bBContext.BB_Injector.Add(injector);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Injector> GetAllInjectors()
        {
            return bBContext.BB_Injector.ToList();

        }

        public Injector GetInjectorByID(int id)
        {
            throw new NotImplementedException();
        }

        public int GetInjectorCount()
        {
            throw new NotImplementedException();
        }

        public bool RemoveInjector()
        {
            throw new NotImplementedException();
        }

        public bool UpdateInjector()
        {
            throw new NotImplementedException();
        }
    }
}
