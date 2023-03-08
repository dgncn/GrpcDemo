using GrpcDemo.Category.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Category.Infrastructure.Persistence
{
    internal static class SeedProcessor
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            var categories = new List<Domain.Entities.Category>()
            {
                new Domain.Entities.Category(){ CategoryName = "Film", Id = Guid.NewGuid() },
                new Domain.Entities.Category(){ CategoryName = "Kitap", Id = Guid.NewGuid() }
            };

            modelBuilder.Entity<Domain.Entities.Category>().HasData(categories);

        }
    }
}
