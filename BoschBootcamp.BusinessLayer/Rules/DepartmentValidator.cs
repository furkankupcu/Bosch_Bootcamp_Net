using BoschBootcamp.DTOLayer.Concrete.DTOs.DepartmentDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Rules
{
    public class DepartmentValidator : AbstractValidator<DepartmentDTO>
    {

        public DepartmentValidator() {

            RuleFor(x => x.DepartmentID).NotEmpty().WithMessage("DepartmentId cannot be empty.");
            RuleFor(x => x.DepartmentName).NotEmpty().MaximumLength(3);
            RuleFor(x => x.AreaID).NotEmpty();
        }
    }
}
