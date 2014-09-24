using System;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main()
        {
            var buf = new BoundedBuffer(4);

            var prod = new Producer(buf, 10);
            var con1 = new Consumer(buf);
            var con2 = new Consumer(buf);

            Parallel.Invoke(prod.Run, con1.Run, con2.Run);

            Console.WriteLine("");
        }
    }
}
