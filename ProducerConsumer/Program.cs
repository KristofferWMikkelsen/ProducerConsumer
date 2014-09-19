using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main()
        {
            var buf = new BoundedBuffer(4);

            var prod = new Producer(buf, 10);
            var con = new Consumer(buf);

            Parallel.Invoke(prod.Run, con.Run);
        }
    }
}
