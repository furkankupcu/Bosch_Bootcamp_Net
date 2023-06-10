using BoschBootcamp.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.BusinessRules
{
    public class OrderBusinessRule
    {
        private readonly BBContext _bBContext;

        public OrderBusinessRule(BBContext bBContext)
        {
            this._bBContext = bBContext;
        }

        public bool OrderIsExist(int orderId)
        {
            return _bBContext.BB_Order.Any(b => b.OrderID == orderId);
        }
    }
}
