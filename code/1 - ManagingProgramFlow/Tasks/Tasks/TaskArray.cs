using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class TaskArray
    {
        private void DoWork(int id)
        {
            Console.WriteLine("Starting  DoWork {0}", id);
            Thread.Sleep(500);
            Console.WriteLine("Finishing DoWork {0}", id);
        }

        public void ExecuteTasks()
        {
            Console.WriteLine("Task Array");
            Console.WriteLine("..............");
            var tasks = new Task[5] ;

            for (var i = 0; i < 5; i++)
            {
                var taskNum = i;
                tasks[i] = Task.Run(() => DoWork(taskNum));
            }

            //Pause the program until all task finishes.
            Task.WaitAll(tasks);
        }
    }
}
