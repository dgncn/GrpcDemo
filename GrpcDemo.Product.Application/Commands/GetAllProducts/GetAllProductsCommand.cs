using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcDemo.Product.Application.Commands.GetAllProducts
{
    internal class GetAllProductsCommand  : IRequest<GetAllProductsCommandResponse>
    {

    }
}
