using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface ISubcomponentTypesService
    {
        public List<SubcomponentTypes> GetSubcomponentTypes();

        public List<SubcomponentTypes> GetSubcomponentTypesByStationId(int stationId);
    }
}
