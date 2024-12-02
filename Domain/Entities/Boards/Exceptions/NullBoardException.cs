using Xeptions;

namespace Domain.Entities.Exceptions;

public class NullBoardException : Xeption
{
    public NullBoardException()
        : base(message: "Board is null.")
    { }
}