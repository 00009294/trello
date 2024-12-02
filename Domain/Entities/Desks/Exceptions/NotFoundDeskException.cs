using Xeptions;

namespace Domain.Entities.Exceptions;
public class NotFoundDeskException : Xeption
{
    public NotFoundDeskException(int id)
        : base(message: $"Couldn't found desk with id: {id}")
    { }
}

