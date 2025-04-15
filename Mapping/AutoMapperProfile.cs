using AutoMapper;
using SampleApiReact.DTOS;
using SampleApiReact.Model;

namespace SampleApiReact.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
