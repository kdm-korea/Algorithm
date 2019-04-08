using System;
using System.Collections.Generic;
using System.Text;

namespace CircleQueue
{
    class CircleQueue<T> : ICircleQueue<T>
    {
        private T[] cicleQueue;

        /// <summary>
        /// 원형큐를 만들때는 큐의 크기가 있어야 합니다.
        /// </summary>
        /// <param name="index"></param>
        public CircleQueue(int index) {
            cicleQueue = new T[index];
        }

        public void Clear() {
            throw new NotImplementedException();
        }

        public int Count() {
            throw new NotImplementedException();
        }

        public void Dequeue() {
            throw new NotImplementedException();
        }

        public void Enqueue(T item) {
            throw new NotImplementedException();
        }

        public int Front() {
            throw new NotImplementedException();
        }

        public T Peek() {
            throw new NotImplementedException();
        }

        public int Rear() {
            throw new NotImplementedException();
        }
    }
}
