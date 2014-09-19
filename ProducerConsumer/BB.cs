using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class BoundedBuffer
    {

        private int _cap;
        private Queue<int> _queue;
        public BoundedBuffer(int capacity)
        {
            this._cap = capacity;
            this._queue = new Queue<int>(capacity);
        }

        public Boolean isFull()
        {
            return true;
        }

        public void Put(int element)
        {
            this._queue.Enqueue(element);
        }

        public int Take()
        {
            int temp = this._queue.Dequeue();
            return temp;
        }


    }
}
