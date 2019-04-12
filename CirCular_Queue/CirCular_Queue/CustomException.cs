using System;

namespace CirCular_Queue
{
    class CustomException : Exception
    {
        public CustomException() : base()
        {
        }

        public CustomException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message);
        }
    }
}
