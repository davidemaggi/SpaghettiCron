using System;
using System.Collections.Generic;
using System.Text;

namespace SpaghettiCron.Lib.Exceptions
{
    public class ElementAlreadySetException : Exception
    {
        public ElementAlreadySetException()
        {
        }

        public ElementAlreadySetException(string message)
            : base(message)
        {

        }

        public ElementAlreadySetException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
