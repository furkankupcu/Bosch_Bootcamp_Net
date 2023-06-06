using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IAreaService
    {

        public bool AddArea(Area area);

        public bool DeleteArea(Area area);

        public bool UpdateArea(Area area);

        public Area GetAreaByID(int id);

        public List<Area> GetAllAreas();

        public int GetAreaCount();
    }
}
