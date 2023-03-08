using GrpcDemo.Product.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace GrpcDemo.Product.Application.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, GetAllProductsQueryResponse>
    {
        private readonly IProductContext _productContext;
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(IProductContext productContext, IMapper mapper)
        {
            _productContext = productContext;
            _mapper = mapper;
        }
        public async Task<GetAllProductsQueryResponse> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productContext.Products.ToListAsync();
            var responseModel = _mapper.Map<List<Domain.Entities.Product>, GetAllProductsQueryResponse>(products);
            return responseModel;
        }
    }
}
