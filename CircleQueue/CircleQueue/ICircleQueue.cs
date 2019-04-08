using System;
using System.Collections.Generic;
using System.Text;

namespace CircleQueue
{
    interface ICircleQueue<T>
    {
        void Enqueue(T item);
        void Dequeue();
        void Clear();
        int Count();
        T Peek();
        int Rear();
        int Front();
    }
}
