using GrpcDemo.Category.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Category.Infrastructure.Persistence;

public class CategoryContext : DbContext, ICategoryContext
{
    public CategoryContext(DbContextOptions<CategoryContext> dbContextOptions) : base(dbContextOptions)
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

    public DbSet<Domain.Entities.Category> Categories { get; set; }

    
}
