using Domain.Common;

namespace Domain.Entities;

public class Attachement : BaseAuditableEntity
{
    public string FileName { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Size { get; set; }

    #region ForeignKeys
    public Card Card { get; set; }
    public required int CardId { get; set; }
    #endregion
}