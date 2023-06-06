using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.EntityLayer.Concrete
{
    public class Area
    {
        [Key]
        public char AreaId { get; set; }

        public string? AreaName { get; set; }
    }
}
