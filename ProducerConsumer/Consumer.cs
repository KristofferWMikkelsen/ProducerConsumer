using System;
using System.Threading;

namespace ProducerConsumer
{
    class Consumer
    {
        private BoundedBuffer buf;
        public Consumer(BoundedBuffer obj)
        {
            buf = obj;
        }
        public void Run()
        {
            if (buf.MyQueue.Count != 0)
            {
                buf.Take();
                Console.WriteLine("Line removed");
            }           
        }

    }
}
