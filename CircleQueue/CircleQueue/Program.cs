using System;
using System.Collections.Generic;

namespace CircleQueue
{
    class Program
    {
        public static CircleQueue<string> circleQueue;

        static void Main(string[] args) {
            circleQueue = new CircleQueue<string>(4);

            circleQueue.Enqueue("김동민1");
            circleQueue.Enqueue("김동민2");
            circleQueue.Enqueue("김동민3");
            circleQueue.Enqueue("김동민4");
            PrtQueue("첫번째 출력", circleQueue);

            circleQueue.Dequeue();
            PrtQueue("두번째 출력", circleQueue);

            circleQueue.Enqueue("김동민5");
            PrtQueue("세번째 출력", circleQueue);

            circleQueue.Dequeue();
            PrtQueue("네번째 출력", circleQueue);

            circleQueue.Enqueue("김동민6");
            PrtQueue("다섯번째 출력", circleQueue);

            circleQueue.Dequeue();
            PrtQueue("여섯번째 출력", circleQueue);

            circleQueue.Enqueue("김동민7");
            PrtQueue("일곱번째 출력", circleQueue);
        }

        public static void PrtQueue(string count, CircleQueue<string> circleQueue) {
            Console.WriteLine(count);
            Console.WriteLine("==============================");
            for (int idx = 0; idx < circleQueue.Length; idx++) {
                Console.WriteLine(circleQueue[idx]);
            }
            Console.WriteLine("==============================");
            Console.WriteLine();
        }
    }
}
