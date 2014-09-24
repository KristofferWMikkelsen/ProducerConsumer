using System;
using System.Threading;

namespace ProducerConsumer
{
    class Consumer
    {
        private int max;
        private BoundedBuffer _buffer;
        public Consumer(BoundedBuffer buffer)
        {
            this._buffer = buffer;
            //this.max = expectedAmount;
        }

        public void Run()
        {
            //for (int i = 0; i < this.max  ; i++)
            //{
            //    int temp = this._buffer.Take();
                
            //}

            int temp;
            do
            {
                temp = this._buffer.Take();
                
            } while (temp !=-1);
        }
    }
}
