using BoschBootcamp.BusinessLayer.Response;
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

        public BusinessResponse AddStationProcess(StationProcess stationProcess);

        public BusinessResponse UpdateStationProcess(StationProcess stationProcess);

        public BusinessResponse DeleteStationProcess(StationProcess stationProcess);

        public Station GetStationProcessById(int id);

        public int GetStationProcessCount();
    }
}
