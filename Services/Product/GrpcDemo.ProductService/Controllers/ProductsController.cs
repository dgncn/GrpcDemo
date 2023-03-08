using MediatR;
using Microsoft.AspNetCore.Mvc;
using GrpcDemo.Product.Application.Queries.GetAllProducts;

namespace GrpcDemo.ProductService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IMediator mediator, ILogger<ProductsController> logger)
        {
            _mediator=mediator;
            _logger=logger;
        }

        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllProductsQuery());
            return Ok(result);
        }
    }
}