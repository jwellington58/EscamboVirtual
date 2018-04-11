using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class EscamboException : Exception
    {
        public EscamboException(string message) :
            base(message)
        { }
    }

}
