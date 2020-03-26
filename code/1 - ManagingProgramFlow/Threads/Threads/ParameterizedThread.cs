using System;
using System.Threading;

namespace Threads
{
    public class ParameterizedThread
    {
        private void DoWork(object data)
        {
            Console.WriteLine("working on {0}", data);
            Thread.Sleep(2000);
        }

        public void ExecuteThread()
        {
            var ps = new ParameterizedThreadStart(DoWork);
            var thread = new Thread(ps);
            thread.Start(99);
        }
    }
}
