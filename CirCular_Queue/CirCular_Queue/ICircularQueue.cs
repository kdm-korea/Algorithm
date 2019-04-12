namespace CirCular_Queue
{
    interface ICircularQueue<T>
    {
        bool Enqueue(T item);
        bool Dequeue();
        void Clear();
        int Count();
    }
}
