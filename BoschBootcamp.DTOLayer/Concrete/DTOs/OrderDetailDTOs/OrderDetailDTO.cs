using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.OrderDetailDTOs
{
    public class OrderDetailDTO
    {
        public int OrderID { get; set; }

        public string? ModelNumber { get; set; }

        public int OrderQuantity { get; set; }
    }
}
