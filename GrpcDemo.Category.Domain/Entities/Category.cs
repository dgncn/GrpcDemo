using GrpcDemo.Category.Domain.Entities.Base;

namespace GrpcDemo.Category.Domain.Entities;

public class Category : BaseEntity
{
    public string CategoryName { get; set; } = null!;
}
