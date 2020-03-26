using System;

namespace AsyncAwait
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Async and await
            var asyncAwait = new AsyncAwait();
            asyncAwait.ExecuteTask();

            //Awaiting parallel tasks: Task.WhenAll
            var lt = new AsyncAwaitForListOfTasks();
            lt.ExecuteTask();

            //Multiple awaiting task --> it execute sequentially each one
            var x = new AsyncWithMultiplesAwait();
            x.ExecuteTask();

            Console.ReadKey();
        }
    }
}
