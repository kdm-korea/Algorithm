using System;
using System.Collections.Generic;
using System.Text;

namespace CircleQueue
{
    class CustomException : Exception
    {
        public CustomException() : base() {
        }

        public CustomException(string message) : base(message) {
            Console.WriteLine(message);
        }

        public CustomException(string message, Exception innerException) : base(message, innerException) {
            Console.WriteLine(message);
        }
    }
}
