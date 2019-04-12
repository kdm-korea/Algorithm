using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirCular_Queue
{
    class Program
    {
        public static CircularQueue<string> circularQueue;

        static void Main(string[] args)
        {
            circularQueue = new CircularQueue<string>(4);

            circularQueue.Enqueue("김동민1");
            circularQueue.Enqueue("김동민2");
            circularQueue.Enqueue("김동민3");
            circularQueue.Enqueue("김동민4");
            PrtQueue("첫번째 출력", circularQueue);

            circularQueue.Dequeue();
            PrtQueue("두번째 출력", circularQueue);

            circularQueue.Enqueue("김동민5");
            PrtQueue("세번째 출력", circularQueue);

            circularQueue.Dequeue();
            PrtQueue("네번째 출력", circularQueue);

            circularQueue.Enqueue("김동민6");
            PrtQueue("다섯번째 출력", circularQueue);

            circularQueue.Dequeue();
            PrtQueue("여섯번째 출력", circularQueue);

            circularQueue.Enqueue("김동민7");
            PrtQueue("일곱번째 출력", circularQueue);
        }

        public static void PrtQueue(string count, CircularQueue<string> circleQueue)
        {
            Console.WriteLine(count);
            Console.WriteLine("==============================");
            for (int idx = 0; idx < circleQueue.Length; idx++)
            {
                Console.WriteLine(circleQueue[idx]);
            }
            Console.WriteLine("==============================");
            Console.WriteLine();
        }
    }
}
