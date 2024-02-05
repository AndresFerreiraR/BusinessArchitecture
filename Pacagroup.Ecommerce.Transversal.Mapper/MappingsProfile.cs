using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pacagroup.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDto>().ReverseMap();
            CreateMap<Users, UsersDto>().ReverseMap();
        }
    }
}
