using AutoMapper;
using GrpcDemo.Product.Application.Models;
using GrpcDemo.Product.Application.Queries.GetAllProducts;

namespace GrpcDemo.Product.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Domain.Entities.Product, ProductViewModel>()
                .ForMember(x => x.Name, option => option.MapFrom(y => y.ProductName))
                .ForMember(x => x.Price, option => option.MapFrom(y => y.ProductPrice));

            CreateMap<List<Domain.Entities.Product>, GetAllProductsQueryResponse>()
                .ForMember(x => x.Products,
                option => option.MapFrom(x => x));
        }
    }
}
