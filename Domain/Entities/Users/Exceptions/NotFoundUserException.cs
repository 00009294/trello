using Xeptions;

namespace Domain.Entities.Exceptions;

public class NotFoundUserException : Xeption
{
    public NotFoundUserException(int id)
        : base(message: $"Couldn't found user with id: {id}")
    { }
}