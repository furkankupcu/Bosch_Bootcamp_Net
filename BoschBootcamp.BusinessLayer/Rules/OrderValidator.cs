using BoschBootcamp.DTOLayer.Concrete.DTOs.OrderDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class OrderValidator : AbstractValidator<OrderDTO>
    {
        public OrderValidator()
        {
            RuleFor(x => x.OrderID).NotEmpty();
            RuleFor(x => x.OrderStatus).Length(2, 15);
            RuleFor(x => x.OrderID).GreaterThanOrEqualTo(x => x.OrderID);
        }
    }
}
