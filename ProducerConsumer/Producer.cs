using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Producer
    {

        private int Max;
        private BoundedBuffer _buffer;
        public Producer(BoundedBuffer buffer, int howManyToProduce)
        {
            this.Max = howManyToProduce;
            this._buffer = buffer;
        }

        public void Run()
        {
            for (int i = 0; i < this.Max; i++)
            {
                
                    this._buffer.Put(i);
                    
            }

            this._buffer.Put(-1);
        }
    }
}
