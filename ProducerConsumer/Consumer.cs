using System;
using System.Threading;

namespace ProducerConsumer
{
    class Consumer
    {
        private int max;
        private BoundedBuffer _buffer;
        public Consumer(BoundedBuffer buffer, int expectedAmount)
        {
            this._buffer = buffer;
            this.max = expectedAmount;
        }

        public void Run()
        {
            for (int i = 0; i < this.max  ; i++)
            {
                int temp = this._buffer.Take();
                Console.WriteLine("Consumer just took {0} from the buffer", temp);
            }
        }
    }
}
