using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Category.Infrastructure.Persistence
{
    public interface ICategoryContext
    {
        DbSet<Domain.Entities.Category> Categories { get; set; }

        Task<int> SaveChanges();
    }
}