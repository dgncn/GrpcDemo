using System.ComponentModel.DataAnnotations;

namespace GrpcDemo.Category.Domain.Entities.Base;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}
