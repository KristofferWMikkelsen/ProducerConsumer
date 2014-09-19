using System;
using System.Threading;

namespace ProducerConsumer
{
    class Producer
    {
        public int HowMany;
        private BoundedBuffer buf;

        public Producer(BoundedBuffer obj, int i)
        {
            HowMany = i;
            buf = obj;
        }

        public void Run()
        {
            for (int i = 0; i < HowMany; i++)
            {
                if (!buf.IsFull())
                {
                    var rnd = new Random();
                    int number = rnd.Next(1, 1000);
                    buf.Put(number);
                    Console.WriteLine("Line added");
                }
            }
        }
    }
}
