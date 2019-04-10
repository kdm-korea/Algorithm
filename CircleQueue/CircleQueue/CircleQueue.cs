using System;
using System.Collections.Generic;
using System.Text;

namespace CircleQueue
{
    class CircleQueue<T> : ICircleQueue<T>
    {
        private T[] circleQueue;
        private int rear = 0, front = 0, queSize = 0, peek = 0;

        public CircleQueue(int size) {
            this.queSize = size;
            circleQueue = new T[this.queSize];
        }

        public void Clear() {
            for (int idx = 0; idx < circleQueue.Length; idx++) {
                Pop(idx);
            }
            rear = 0;
            front = 0;
            queSize = 0;
            peek = 0;
        }

        public bool Dequeue() {
            if (Pop(front)) {
                return true;
            }
            else {
                new CustomException("InvalidCastException :: 큐가 비어있습니다.");
                return false;
            }
        }

        private bool Pop(int item) {
            if (!item.Equals(rear)) {
                ReCycleOfMemory(ref front);
                circleQueue[front] = default(T);
                return true;
            }
            else {
                return false;
            }
        }

        public bool Enqueue(T item) {
            if (IsOutOfRangeCircleQueue()) {
                new CustomException("ArgumentOutOfRangeException :: 큐에 공간이 없습니다.");
                return false;
            }
            else {
                ReCycleOfMemory(ref rear);
                circleQueue[rear] = item;
                peek = rear;
                return true;
            }
        }

        private void ReCycleOfMemory(ref int value) {
            value++;
            if ((value % (queSize)).Equals(0)) {
                value = 0;
            }
        }

        private bool IsOutOfRangeCircleQueue() => (Count() + 1).Equals(queSize) ? true : false;

    }
}
