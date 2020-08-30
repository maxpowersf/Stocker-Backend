using AutoMapper;
using Stocker.API.DTO;
using Stocker.Data.Entities;
using Stocker.Domain;

namespace Stocker.API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, Categories>()
                .ForMember(e => e.CategoryId, opt => opt.MapFrom(e => e.Id)).ReverseMap();

            CreateMap<ProductDTO, Product>();
            CreateMap<Product, Products>()
                .ForMember(e => e.ProductId, opt => opt.MapFrom(e => e.Id)).ReverseMap();
        }
    }
}
