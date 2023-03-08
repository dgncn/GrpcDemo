using GrpcDemo.Product.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcDemo.Product.Application.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public List<ProductViewModel> Products { get; set; } = null!;
    }
}
