using System;
using System.Collections.Generic;
using System.Text;

namespace SpaghettiCron.Lib.Exceptions
{
    public class ElementNotInValidRangeException : Exception
    {
        public ElementNotInValidRangeException()
        {
        }

        public ElementNotInValidRangeException(string message)
            : base(message)
        {

        }

        public ElementNotInValidRangeException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
