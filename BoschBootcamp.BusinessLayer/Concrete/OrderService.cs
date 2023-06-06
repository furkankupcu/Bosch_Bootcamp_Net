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
    public class OrderService : IOrderService
    {
        private readonly BBContext bBContext;

        public OrderService(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public int GetModelCount(string id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            return bBContext.BB_Order.ToList();
        }

        public bool UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
