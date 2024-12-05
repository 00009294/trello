using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xeptions;

namespace Domain.Entities.Attachements.Exceptions
{
    public class AlreadyExistsAttachementException : Xeption
    {
        public AlreadyExistsAttachementException(Exception innerException)
            : base(message: "An attachement already exists! ", innerException)
        { }
    }
}
