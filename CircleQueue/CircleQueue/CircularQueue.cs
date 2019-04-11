
namespace Circular_Queue
{
    class CircularQueue<T> : ICircularQueue<T>
    {
        private T[] circularQueue;
        private int rear = 0, front = 0, queSize = 0, peek = 0;

        public CircularQueue(int size) {
            this.queSize = size;
            circularQueue = new T[this.queSize];
        }

        public void Clear() {
            for (int idx = 0; idx < circularQueue.Length; idx++) {
                Remove(idx);
            }
            rear = 0;
            front = 0;
            queSize = 0;
            peek = 0;
        }

        public bool Dequeue() {
            if (Remove(front)) {
                return true;
            }
            else {
                new CustomException("InvalidCastException :: 큐가 비어있습니다.");
                return false;
            }
        }

        public bool Enqueue(T item) {
            if (IsOutOfRangeCircularQueue()) {
                new CustomException("ArgumentOutOfRangeException :: 큐에 공간이 없습니다.");
                return false;
            }
            else {
                ReCycleOfMemory(ref rear);
                circularQueue[rear] = item;
                peek = rear;
                return true;
            }
        }

        private bool Remove(int item) {
            if (!item.Equals(rear)) {
                ReCycleOfMemory(ref front);
                circularQueue[front] = default(T);
                return true;
            }
            else {
                return false;
            }
        }

        public int Count() => (rear >= front) ? (rear - front) : (rear - front + queSize);

        public T this[int index] => circularQueue[index];

        private void ReCycleOfMemory(ref int value) {
            value++;
            if ((value % (queSize)).Equals(0)) {
                value = 0;
            }
        }

        private bool IsOutOfRangeCircularQueue() => (Count() + 1).Equals(queSize) ? true : false;

        public int Front => this.front;

        public int Rear => this.rear;

        public T Peek => this.circularQueue[peek];

        public int Length => this.queSize;
    }
}
