using BoschBootcamp.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.BusinessRules
{
    public class OrderDetailBusinessRules
    {
        private readonly BBContext _bBContext;

        public OrderDetailBusinessRules(BBContext bContext)
        {
            _bBContext = bContext;
        }

        public bool OrderDetailIsExist(int orderId, string ModelNumber)
        {
            return _bBContext.BB_OrderDetail.Any(b => b.OrderID == orderId) && _bBContext.BB_OrderDetail.Any(b => b.ModelNumber == ModelNumber);
        }
    }
}
