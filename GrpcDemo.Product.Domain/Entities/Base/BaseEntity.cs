using System.ComponentModel.DataAnnotations;

namespace GrpcDemo.Product.Domain.Entities.Base;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}
