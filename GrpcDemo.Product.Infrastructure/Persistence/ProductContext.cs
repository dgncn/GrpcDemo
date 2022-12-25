using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Product.Infrastructure.Persistence;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Domain.Entities.Product> Products { get; set; }
}
