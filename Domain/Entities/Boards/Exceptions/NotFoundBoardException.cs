using Xeptions;

namespace Domain.Entities.Exceptions;

public class NotFoundBoardException : Xeption
{
    public NotFoundBoardException(int id)
        : base(message: $"Couldn't find board with id: {id}.")
    { }
}