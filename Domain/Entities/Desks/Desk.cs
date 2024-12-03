using Domain.Common;

namespace Domain.Entities;

public class Desk : BaseAuditableEntity
{
    public required string Name { get; set; }
    public IEnumerable<Card>? Cards { get; set; }

    #region ForeignKeys

    public Board Board { get; set; }
    public required int BoardId { get; set; }

    #endregion
}