using System;
using System.Collections.Generic;
using System.Text;

namespace CircleQueue
{
    interface ICircleQueue<T>
    {
        bool Enqueue(T item);
        bool Dequeue();
        void Clear();
        int Count();
    }
}
