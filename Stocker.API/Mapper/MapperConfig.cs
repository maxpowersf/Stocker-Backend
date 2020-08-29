using AutoMapper;
using Stocker.API.DTO;
using Stocker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocker.API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category, Data.Entities.Categories>()
                .ForMember(e => e.CategoryId, opt => opt.MapFrom(e => e.Id)).ReverseMap();
        }
    }
}
