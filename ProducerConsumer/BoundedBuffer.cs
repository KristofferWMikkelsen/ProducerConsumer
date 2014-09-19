using System;
using System.Collections.Generic;
using System.Threading;

namespace ProducerConsumer
{
    class BoundedBuffer
    {

        public Queue<int> Queue = new Queue<int>();
        public int Max = 0;
        public BoundedBuffer(int i)
        {
            Max = i;
        }

        public bool Full()
        {
            if (Max == Queue.Count)
            {
                return true;
            }
            return false;
        }

        public void Put(int number)
        {
            Queue.Enqueue(number);
        }

        public int Get()
        {
            return Queue.Dequeue();
        }


    }
}
