using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.BusinessRules;
using BoschBootcamp.BusinessLayer.Response;
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
    public class InjectorManager : IInjectorService
    {
        private readonly BBContext bBContext;
        private readonly InjectorBusinessRule _injectorBusinessRule;

        public InjectorManager(BBContext bBContext, InjectorBusinessRule ınjectorBusinessRule)
        {
            this.bBContext = bBContext;
            this._injectorBusinessRule = ınjectorBusinessRule;
        }

        public BusinessResponse AddInjector(Injector injector)
        {
            var result = _injectorBusinessRule.InjectorIsExist(injector.Injector_ID);
            if (!result)
            {
                try
                {
                    bBContext.BB_Injector.Add(injector);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Injector added successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
                
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The injector already exists." };
            }
        }

        public BusinessResponse DeleteInjector(Injector injector)
        {
            var result = _injectorBusinessRule.InjectorIsExist(injector.Injector_ID);
            if (result)
            {
                try
                {
                    bBContext.BB_Injector.Remove(injector);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Model deleted successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The injector not exists." };
            }
        }

        public BusinessResponse UpdateInjector(Injector injector)
        {
            var result = _injectorBusinessRule.InjectorIsExist(injector.Injector_ID);
            if (result)
            {
                try
                {
                    bBContext.Update(injector);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "The injector updated successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The injector not exists." };
            }
        }

        public List<Injector> GetAllInjectors()
        {
            return bBContext.BB_Injector.ToList();
        }

        public Injector GetInjectorByID(int id)
        {
            return bBContext.BB_Injector.Where(X => X.Injector_ID == id).FirstOrDefault();
        }

        public int GetInjectorCount()
        {
            return bBContext.BB_Injector.Count();
        }

        
    }
}
