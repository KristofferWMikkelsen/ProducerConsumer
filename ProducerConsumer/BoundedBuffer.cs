using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public bool isFull()
        {
            if (this._queue.Count >= this._cap)
            {
                return true;
            }
            return false;
        }

        

        public void Put(int element)
        {
            lock (_queue)
            {
                while (this.isFull())
                {
                    Monitor.Wait(_queue);
                }
                this._queue.Enqueue(element);
                Console.WriteLine("Element was added {0} to the buffer on the thread", element);
                Monitor.PulseAll(_queue);
            }
        }

        public int Take()
        {
            lock (_queue)
            {
                while (this._queue.Count == 0)
                {
                    Monitor.Wait(_queue);
                }
            
                int temp = this._queue.Dequeue();
                Console.WriteLine("Element was just took removed {0} from the buffer", temp);
                Monitor.PulseAll(_queue);
                return temp;
            }
            
        }


    }
}
