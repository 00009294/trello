using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities;

public class Board : BaseAuditableEntity
{
    [MinLength(5, ErrorMessage = "Board name should have at least 5 characters.")]
    public required string Name { get; set; }
    public string Description { get; set; } = string.Empty;
    public IEnumerable<Desk>? Desks { get; set; }
    public IEnumerable<User>? Users { get; set; }
}