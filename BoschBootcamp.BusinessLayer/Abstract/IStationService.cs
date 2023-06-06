using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IStationService
    {
        public List<Station> GetAllStations();

        public bool AddStation(Station station);

        public bool UpdateStation(Station station);

        public bool DeleteStation(Station station);

        public Station GetStationById(int id);

        public int GetStationCount();
    }
}
