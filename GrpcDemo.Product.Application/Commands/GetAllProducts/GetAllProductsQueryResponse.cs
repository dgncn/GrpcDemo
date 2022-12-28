using GrpcDemo.Product.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcDemo.Product.Application.Commands.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public List<ProductViewModel> Products = null!;
    }
}
