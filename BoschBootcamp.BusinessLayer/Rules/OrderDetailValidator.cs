using BoschBootcamp.DTOLayer.Concrete.DTOs.OrderDetailDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class OrderDetailValidator : AbstractValidator<OrderDetailDTO>
    {
        public OrderDetailValidator() {
        
            RuleFor(x => x.OrderID).NotEmpty();
            RuleFor(x => x.ModelNumber).NotEmpty().Length(1,3);
            RuleFor(x => x.OrderQuantity).NotEmpty().GreaterThan(5);
        
        }
    }
}
