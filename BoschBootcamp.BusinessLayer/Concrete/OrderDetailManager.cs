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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly BBContext bBContext;

        public OrderDetailManager(BBContext bBContext)
        {
            this.bBContext = bBContext;
        }

        public bool AddOrderDetail(OrderDetail model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOrderDetail(OrderDetail model)
        {
            throw new NotImplementedException();
        }

        public int GetModelCount(string id)
        {
            throw new NotImplementedException();
        }

        public int GetModelCount(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetOrderDetailByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return bBContext.BB_OrderDetail.ToList();
        }

        public bool UpdateOrderDetail(OrderDetail model)
        {
            throw new NotImplementedException();
        }
    }
}
