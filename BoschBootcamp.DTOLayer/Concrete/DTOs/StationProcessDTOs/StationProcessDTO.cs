using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.StationProcessDTOs
{
    public class StationProcessDTO
    {
        public int StationID { get; set; }

        public int InjectorID { get; set; }

        public int SubcomponentID { get; set; }

        public DateTime ProcessTime { get; set; }

        public string? ProcessStatus { get; set; }
    }
}
