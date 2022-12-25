using GrpcDemo.Product.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GrpcDemo.Product.Infrastructure.Persistence
{
    internal static class SeedProcessor
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            var products = new List<Domain.Entities.Product>()
            {
                new Domain.Entities.Product(){ ProductName = "Donnie Darko", ProductPrice = 46.4m, Id = Guid.NewGuid() },
                new Domain.Entities.Product(){ ProductName = "Çöküş", ProductPrice = 76, Id = Guid.NewGuid() }
            };

            modelBuilder.Entity<Domain.Entities.Product>().HasData(products);

        }
    }
}
