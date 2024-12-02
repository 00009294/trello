using Xeptions;

namespace Domain.Entities.Exceptions;

public class AlreadyExistsDeskException : Xeption
{
    public AlreadyExistsDeskException(Exception innerException)
        : base(message: "The desk already exists.", innerException )
    { }
}