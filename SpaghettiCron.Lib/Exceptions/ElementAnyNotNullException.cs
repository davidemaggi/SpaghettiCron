using System;
using System.Collections.Generic;
using System.Text;

namespace SpaghettiCron.Lib.Exceptions
{
    public class ElementAnyNotNullException : Exception
    {
        public ElementAnyNotNullException()
        {
        }

        public ElementAnyNotNullException(string message)
            : base(message)
        {

        }

        public ElementAnyNotNullException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
