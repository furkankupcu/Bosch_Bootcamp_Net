using BoschBootcamp.DTOLayer.Concrete.DTOs.InjectorDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    internal class InjectorValidator : AbstractValidator<InjectorDTO>
    {

        public InjectorValidator() {
            RuleFor(x => x.InjectorID).NotEmpty().WithMessage("InjectorId cannot be empty.");
            RuleFor(x => x.ModelNumber).NotEmpty();
            RuleFor(x => x.InjectorStatus).Length(3,20);
            RuleFor(x => x.OrderID).NotEmpty();
        }
    }
}