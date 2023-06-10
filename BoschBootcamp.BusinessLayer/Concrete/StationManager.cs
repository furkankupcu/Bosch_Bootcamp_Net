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

    public class StationManager : IStationService
    {
        private readonly BBContext bBContext;

        public StationManager(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddStation(Station station)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStation(Station station)
        {
            throw new NotImplementedException();
        }

        public List<Station> GetAllStations()
        {
            return bBContext.BB_Station.ToList();
        }

        public Station GetStationById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetStationCount()
        {
            throw new NotImplementedException();
        }

        public bool UpdateStation(Station station)
        {
            throw new NotImplementedException();
        }
    }
}
