using AutoMapper;
using GrpcDemo.Product.Application.Models;

namespace GrpcDemo.Product.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Domain.Entities.Product, ProductViewModel>();
        }
    }
}
