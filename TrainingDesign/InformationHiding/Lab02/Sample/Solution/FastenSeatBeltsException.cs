using System;
using System.Collections.Generic;
using System.Text;

namespace InformationHiding.Lab02.Sample.Solution
{
    class FastenSeatBeltsException : Exception
    {
        public FastenSeatBeltsException()
        {
        }

        public FastenSeatBeltsException(string message)
            : base(message)
        {
        }

        public FastenSeatBeltsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
