using MediatR;

namespace GrpcDemo.Product.Application.Commands.GetAllProducts
{
    internal class GetAllProductsCommandHandler : IRequestHandler<GetAllProductsCommand, GetAllProductsCommandResponse>
    {
        public Task<GetAllProductsCommandResponse> Handle(GetAllProductsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
