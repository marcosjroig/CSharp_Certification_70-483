using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class ContinuationTask
    {
        private void TaskAntecedent()
        {
            Console.WriteLine("Task Antecedent starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task Antecedent finishing");
        }

        private void TaskContinuation()
        {
            Console.WriteLine("Task Continuation starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task Continuation finishing");
        }

        public void ExecuteTasks()
        {
            var task = Task.Run(() => TaskAntecedent());
            task.ContinueWith( prevTask => TaskContinuation());
        }
    }
}
