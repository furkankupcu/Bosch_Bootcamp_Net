using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.DTOLayer.Concrete.DTOs.OrderDTOs
{
    public class OrderDTO
    {
        public int OrderID { get; set; }

        public string? OrderStatus { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
