using Xeptions;

namespace Domain.Entities.Exceptions;

public class AlreadyExistsCardException : Xeption
{
    public AlreadyExistsCardException(Exception innerException)
        : base(message: "A card already exists.", innerException)
    { }
}