// See https://michaelscodingspot.com/c-job-queues-part-3-with-tpl-dataflow-and-failure-handling/
using System;
using System.Linq;
using System.Threading;

namespace dataFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Begin");
                var queue = new TPLDataflowQueue();
                for (var i = 1; i <= 10; i++) {
                    queue.Enqueue(i.ToString());
                }

                var queueMultiThread = new TPLDataflowMultipleHandlers();
                var numbers = Enumerable.Range(1, 10);
                foreach (var num in numbers)
                {
                    queueMultiThread.Enqueue(num.ToString());
                }
                
                var queueBroadcast = new TPLDataflowBroadcast();
                foreach (var num in Enumerable.Range(1, 10))
                {
                    // the broadcast alone will have only 1 message at a time which means that
                    // it has to wait that all the consumers will read it before fetching the next one
                    queueBroadcast.Enqueue(num.ToString());
                }

                // need this sleep because every job enqueued in the multi-threading queue is not necessarily finished 
                // and the main when finished will not ensure that the other threads are finished
                Thread.Sleep(1000);

                Console.WriteLine("End");
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
