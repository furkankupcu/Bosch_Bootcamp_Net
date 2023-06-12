using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.BusinessRules;
using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Concrete
{
    public class StationProcessManager : IStationProcessService
    {
        private readonly BBContext bBContext;
        private readonly StationProcessBusinessRule stationProcessBusinessRule;

        public StationProcessManager(BBContext bBContext, StationProcessBusinessRule stationProcessBusinessRule)
        {
            this.bBContext = bBContext;
            this.stationProcessBusinessRule= stationProcessBusinessRule;
        }

        public BusinessResponse AddStationProcess(StationProcess stationProcess)
        {
            //var result = stationProcessBusinessRule.StationProcessIsExists(stationProcess.InjectorID,stationProcess.SubcomponentID);
            //if (!result)
            //{
                try
                {
                    bBContext.BB_StationProcess.Add(stationProcess);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success= true , Message= "Station Process added successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success= false, Message= e.Message };
                }
            //}
            //else
            //{
               // return new BusinessResponse { Success = false, Message = "Station Process already exists." };
            //}
        }

        public BusinessResponse DeleteStationProcess(StationProcess stationProcess)
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

        public BusinessResponse UpdateStationProcess(StationProcess stationProcess)
        {
            throw new NotImplementedException();
        }
    }
}
