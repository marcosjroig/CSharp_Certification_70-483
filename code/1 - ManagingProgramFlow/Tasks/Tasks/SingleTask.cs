using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    //This is a single task that does not return any value.
    public class SingleTask
    {
        private void DoWork()
        {
            Console.WriteLine("Starting  DoWork");
            Thread.Sleep(500);
            Console.WriteLine("Finishing DoWork");
        }

        public void ExecuteSingleTask()
        {
            Console.WriteLine("Single Task");
            Console.WriteLine("..............");
            var task = new Task(DoWork);
            task.Start();
            task.Wait();
        }
    }
}
