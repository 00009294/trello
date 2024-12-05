using Xeptions;

namespace Domain.Entities.Attachements.Exceptions
{
    public class NotFoundAttachementException : Xeption
    {
        public NotFoundAttachementException(int id)
           : base(message: $"Couldn't find attachement with id: {id}.")
        { }
    }
}
