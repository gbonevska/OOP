using System;

namespace Exceptions
{
    class InvalidRangeException<T> : SystemException
    {
        //properties
        public T Start { get; set; }
        public T End { get; set; }
        
        // constructor
        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
