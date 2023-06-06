using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IStationProcessService
    {
        public List<StationProcess> GetStationProcesses();

        public bool AddStationProcess(StationProcess stationProcess);

        public bool UpdateStationProcess(StationProcess stationProcess);

        public bool DeleteStationProcess(StationProcess stationProcess);

        public Station GetStationProcessById(int id);

        public int GetStationProcessCount();
    }
}
