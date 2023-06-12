using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.BusinessRules
{
    public class StationProcessBusinessRule
    {
        private readonly BBContext bBContext;
        public StationProcessBusinessRule(BBContext bBContext) { 
            this.bBContext = bBContext;
        }

        public bool StationProcessIsExists(int ınjectorId, int subcomponentId)
        {
            return false;
            //bBContext.BB_StationProcess.Any(b => b.SubcomponentID == subcomponentId && b.InjectorID == ınjectorId);
        }
    }
}
