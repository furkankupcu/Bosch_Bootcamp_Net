using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Abstract
{
    public interface IOrderDetailService
    {
        public List<OrderDetail> GetOrderDetails();

        public bool AddOrderDetail(OrderDetail orderDetail);

        public bool UpdateOrderDetail(OrderDetail orderDetail);

        public bool DeleteOrderDetail(OrderDetail orderDetail);

        public OrderDetail GetOrderDetailByID(int id);

        public int GetModelCount(int id);
        
    }
}
