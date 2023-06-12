using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.BusinessRules;
using BoschBootcamp.BusinessLayer.Response;
using BoschBootcamp.DataAccessLayer.Concrete;
using BoschBootcamp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly BBContext bBContext;
        private readonly OrderBusinessRule _orderBusinessRule;

        public OrderManager(BBContext bBContext, OrderBusinessRule orderBusinessRule)
        {
            this.bBContext = bBContext;
            this._orderBusinessRule = orderBusinessRule;
        }

        public BusinessResponse AddOrder(Order order)
        {
            var result = _orderBusinessRule.OrderIsExist(order.OrderID);
            if (!result)
            {
                try
                {
                    bBContext.BB_Order.Add(order);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Order added successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The order already exists." };
            }
        }

        public BusinessResponse UpdateOrder(Order order)
        {
            var result = _orderBusinessRule.OrderIsExist(order.OrderID);
            if (result)
            {
                try
                {
                    bBContext.BB_Order.Update(order);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Order updated successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The order not exists." };
            }
        }


        public BusinessResponse DeleteOrder(Order order)
        {
            var result = _orderBusinessRule.OrderIsExist(order.OrderID);
            if (result)
            {
                try
                {
                    bBContext.BB_Order.Remove(order);
                    bBContext.SaveChanges();
                    return new BusinessResponse { Success = true, Message = "Order deleted successfully." };
                }
                catch (Exception e)
                {
                    return new BusinessResponse { Success = false, Message = e.Message };
                }
            }
            else
            {
                return new BusinessResponse { Success = false, Message = "The order not exists." };
            }
        }

        public int GetModelCount(string id)
        {
            return bBContext.BB_Injector.Count();
        }

        public Order GetOrderByID(int id)
        {
            return bBContext.BB_Order.Where(X => X.OrderID == id).FirstOrDefault();
        }

        public List<Order> GetOrders()
        {
            return bBContext.BB_Order.ToList();
        }
    }
}
