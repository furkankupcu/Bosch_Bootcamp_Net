using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IOrderService
    { 
        public List<Order> GetOrders();

        public bool AddOrder(Order order);

        public bool UpdateOrder(Order order);

        public bool DeleteOrder(Order order);

        public OrderDetail GetOrderByID(int id);

        public int GetModelCount(string id);
    }
}
