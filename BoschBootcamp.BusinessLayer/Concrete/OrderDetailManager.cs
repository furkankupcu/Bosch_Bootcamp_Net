using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.BusinessRules;
using BoschBootcamp.BusinessLayer.Response;
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
        private readonly OrderDetailBusinessRules orderDetailBusinessRules;

        public OrderDetailManager(BBContext bBContext, OrderDetailBusinessRules orderDetailBusinessRules)
        {
            this.bBContext = bBContext;
            this.orderDetailBusinessRules= orderDetailBusinessRules;
        }

        public BusinessResponse AddOrderDetail(OrderDetail orderDetail)
        {
            var result = orderDetailBusinessRules.OrderDetailIsExist(orderDetail.OrderID,orderDetail.ModelNumber);
            if (!result)
            {
                try
                {
                    bBContext.BB_OrderDetail.AddAsync(orderDetail);
                    bBContext.SaveChangesAsync();
                    return new BusinessResponse { Success = true, Message = "OrderDetail added successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = true, Message = "OrderDetail already exists." };
            }
        }

        public BusinessResponse DeleteOrderDetail(OrderDetail orderDetail)
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

        public BusinessResponse UpdateOrderDetail(OrderDetail model)
        {
            throw new NotImplementedException();
        }
    }
}
