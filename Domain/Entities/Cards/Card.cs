using Domain.Common;
using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Domain.Entities;

public class Card : BaseAuditableEntity
{
    [MinLength(5, ErrorMessage = "Card name must have at least 5 characters.")]
    public required string ShortName { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime FactStartAt { get; set; }
    public DateTime? FactEndAt { get; set; }

    #region ForeignKeys

    public User Author { get; set; }
    public required int AuthorId { get; set; }
    public User? Performer { get; set; }
    public int? PerformerId { get; set; }
    public State State { get; set; }
    public required int StateId { get; set; }
    public Priority Priority { get; set; }
    public required int PriorityId { get; set; }
    public IEnumerable<Attachment>? Attachments { get; set; }

    #endregion

}