using System;
using System.Threading;

namespace Threads
{
    public class CreateThread
    {
        private void DoWork()
        {
            Console.WriteLine("Hello from Thread");
            Thread.Sleep(2000);
        }

        public void ExecuteThread()
        {
            var thread = new Thread(DoWork);
            thread.Start();
        }
    }
}
