using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IInjectorService
    {
        public BusinessResponse AddInjector(Injector injector);

        public BusinessResponse DeleteInjector(Injector injector);

        public BusinessResponse UpdateInjector(Injector injector);

        public List<Injector> GetAllInjectors();

        public Injector GetInjectorByID(int id);

        public int GetInjectorCount();

        public List<object> getModelsCount();

    }
}
