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
    public class StationProcessService : IStationProcessService
    {
        private readonly BBContext bBContext;

        public StationProcessService(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddStationProcess(StationProcess stationProcess)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStationProcess(StationProcess stationProcess)
        {
            throw new NotImplementedException();
        }

        public Station GetStationProcessById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetStationProcessCount()
        {
            throw new NotImplementedException();
        }

        public List<StationProcess> GetStationProcesses()
        {
            return bBContext.BB_StationProcess.ToList();
        }

        public bool UpdateStationProcess(StationProcess stationProcess)
        {
            throw new NotImplementedException();
        }
    }
}
