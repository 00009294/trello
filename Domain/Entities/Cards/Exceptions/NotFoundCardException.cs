using Xeptions;

namespace Domain.Entities.Exceptions;

public class NotFoundCardException : Xeption
{
    public NotFoundCardException(int id)
        : base(message: $"Couldn't found card with id: {id}")
    { }
}