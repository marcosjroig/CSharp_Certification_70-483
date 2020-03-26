using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    //This is a single task that returns an Integer.
    public class SingleTaskWithResult
    {
        private int CalculateResult()
        {
            Console.WriteLine("Starting  CalculateResult");
            Thread.Sleep(1000);
            Console.WriteLine("Finishing CalculateResult");
            return 99;
        }

        public int ExecuteSingleTask()
        {
            Console.WriteLine("");
            Console.WriteLine("Single Task with Result");
            Console.WriteLine("...........................");
            var task = new Task<int>(CalculateResult);
            task.Start();
            task.Wait();

            return task.Result;
        }
    }
}
