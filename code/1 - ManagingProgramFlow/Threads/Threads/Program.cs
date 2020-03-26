using System;

namespace Threads
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create Thread
            var createThread = new CreateThread();
            createThread.ExecuteThread();

            //Parameterized Thread
            var pt = new ParameterizedThread();
            pt.ExecuteThread();

            //Data storage and Thread local
            var tl = new VariablesWithThreadLocal();
            tl.ExecuteTasks();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
