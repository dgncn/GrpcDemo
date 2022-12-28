using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Product.Infrastructure.Persistence
{
    public interface IProductContext
    {
        DbSet<Domain.Entities.Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}