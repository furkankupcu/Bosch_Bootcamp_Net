using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Concrete
{
    public class SubcomponentTypesManager : ISubcomponentTypesService
    {
        private readonly BBContext bBContext;

        public SubcomponentTypesManager(BBContext bBContext)
        {
            this.bBContext = bBContext;
        } 


        public List<SubcomponentTypes> GetSubcomponentTypes()
        {
            return bBContext.BB_SubcomponentType.ToList();
        }

        public List<SubcomponentTypes> GetSubcomponentTypesByStationId(int stationId)
        {
            return bBContext.BB_SubcomponentType.Where(x => x.StationId == stationId).ToList();
        }
    }
}
