using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IInjectorService
    {
        public bool AddInjector(Injector injector);

        public bool RemoveInjector();

        public bool UpdateInjector();

        public List<Injector> GetAllInjectors();

        public Injector GetInjectorByID(int id);

        public int GetInjectorCount();

    }
}
