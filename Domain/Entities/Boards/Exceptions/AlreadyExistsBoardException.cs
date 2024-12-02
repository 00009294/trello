using Xeptions;

namespace Domain.Entities.Exceptions;

public class AlreadyExistsBoardException : Xeption
{
    public AlreadyExistsBoardException(Exception innerException)
        : base(message: "A board already exists.", innerException)
    { }
}