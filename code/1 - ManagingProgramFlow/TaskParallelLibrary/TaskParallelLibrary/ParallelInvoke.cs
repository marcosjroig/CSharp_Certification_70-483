using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    public class ParallelInvoke
    {
        private void Task1()
        {
            Console.WriteLine("Task1 starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task1 ending");
        }

        private void Task2()
        {
            Console.WriteLine("Task2 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task2 ending");
        }

        public void WriteHeader()
        {
            Console.WriteLine("Parallel.Invoke");
            Console.WriteLine("................");
        }

        public void ExecuteTasks()
        {
            Parallel.Invoke(() =>
            {
                Task1();
                Task2();
            });

            Console.WriteLine("");
        }
    }
}
