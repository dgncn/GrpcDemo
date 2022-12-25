using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Product.Infrastructure.Persistence;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> dbContextOptions) : base(dbContextOptions)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedProcessor.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Domain.Entities.Product> Products { get; set; }
}
