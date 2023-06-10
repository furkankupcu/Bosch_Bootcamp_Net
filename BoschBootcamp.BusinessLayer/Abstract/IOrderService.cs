using BoschBootcamp.BusinessLayer.Response;
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

        public BusinessResponse AddOrder(Order order);

        public BusinessResponse UpdateOrder(Order order);

        public BusinessResponse DeleteOrder(Order order);

        public Order GetOrderByID(int id);

        public int GetModelCount(string id);
    }
}
