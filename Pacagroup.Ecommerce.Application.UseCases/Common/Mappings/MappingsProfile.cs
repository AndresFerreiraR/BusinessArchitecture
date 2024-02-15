using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Domain.Entities;

namespace Pacagroup.Ecommerce.Application.UseCases.Common.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Discount, DiscountDto>().ReverseMap();
        }
    }
}
