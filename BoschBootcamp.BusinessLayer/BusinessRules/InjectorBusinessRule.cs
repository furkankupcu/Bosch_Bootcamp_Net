using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.BusinessRules
{
    public class InjectorBusinessRule
    {
        private readonly BBContext _bBContext;

        public InjectorBusinessRule(BBContext bbContext)
        {
            this._bBContext = bbContext;
        }

        public bool InjectorIsExist(int ınjectorId)
        {
            return _bBContext.BB_Injector.Any(b => b.Injector_ID == ınjectorId);
        }
    }
}
