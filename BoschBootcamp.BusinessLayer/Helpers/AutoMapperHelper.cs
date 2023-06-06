using AutoMapper;
using BoschBootcamp.DTOLayer.Concrete.DTOs.AreaDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.DepartmentDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.InjectorDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.ModelsDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.OrderDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.SectionDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.StationDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.StationProcessDTOs;
using BoschBootcamp.DTOLayer.Concrete.DTOs.SubcomponentDTOs;
using BoschBootcamp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschBootcamp.BusinessLayer.Helpers
{
    public class AutoMapperHelper : Profile
    {
        public AutoMapperHelper() {

            CreateMap<Area, AreaDTO>();
            CreateMap<Department, DepartmentDTO>();
            CreateMap<Injector, InjectorDTO>();
            CreateMap<Models, ModelsDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDetail, OrderDTO>();
            CreateMap<SectionDTO, StationDTO>();
            CreateMap<Station,StationDTO>();
            CreateMap<StationProcess, StationProcessDTO >();
            CreateMap<Subcomponent, SubcomponentDTO >();
        
        }
    }
}
