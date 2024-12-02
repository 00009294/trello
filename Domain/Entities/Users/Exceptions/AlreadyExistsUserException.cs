using Xeptions;

namespace Domain.Entities.Exceptions;

public class AlreadyExistsUserException : Xeption
{
    public AlreadyExistsUserException(Exception innerException)
        : base(message: "User already exists.", innerException)
    { }
}