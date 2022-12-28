using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Product.Infrastructure.Persistence;

public class ProductContext : DbContext, IProductContext
{
    public ProductContext(DbContextOptions<ProductContext> dbContextOptions) : base(dbContextOptions)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedProcessor.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    public async Task<int> SaveChanges()
    {
       return await this.SaveChangesAsync();
    }

    public DbSet<Domain.Entities.Product> Products { get; set; }

    
}
