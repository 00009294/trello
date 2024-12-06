using Domain.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Card : BaseAuditableEntity
{
    [MinLength(5, ErrorMessage = "Card name must have at least 5 characters.")]
    public required string ShortName { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime FactStartAt { get; set; }
    public DateTime? FactEndAt { get; set; }
    public int? PerformerId { get; set; }
    public int StateId { get; set; }
    public int? PriorityId { get; set; }
    public int StatusId { get; set; }

    #region ForeignKeys
    public Desk Desk { get; set; }
    public required int DeskId { get; set; }
    public User Author { get; set; }
    public required int AuthorId { get; set; }
    public User? Performer { get; set; }
    public IEnumerable<Attachement>? Attachements { get; set; }

    #endregion

}