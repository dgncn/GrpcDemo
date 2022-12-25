using GrpcDemo.Product.Domain.Entities.Base;

namespace GrpcDemo.Product.Domain.Entities;

public class Product : BaseEntity
{
    public string ProductName { get; set; } = null!;
    public decimal ProductPrice { get; set; }
}
