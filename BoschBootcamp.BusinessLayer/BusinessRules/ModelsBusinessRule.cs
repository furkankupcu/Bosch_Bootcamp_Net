using BoschBootcamp.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.BusinessRules
{
    public class ModelsBusinessRule
    {
        private readonly BBContext bbContext;

        public ModelsBusinessRule(BBContext bbContext)
        {
            this.bbContext = bbContext;
        }

        public bool ModelIsExist(string modelNumber)
        {
            return bbContext.BB_Models.Any(b => b.ModelNumber == modelNumber);
        }
    }
}
