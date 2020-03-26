using System;

namespace TaskParallelLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke
            var parallelInvoke = new ParallelInvoke();
            parallelInvoke.WriteHeader();
            parallelInvoke.ExecuteTasks();

            //Parallel.ForEach
            var parallelForEach = new ParallelForEach();
            parallelForEach.WriteHeader();
            parallelForEach.ExecuteTasks();

            //Parallel.For
            var parallelFor = new ParallelFor();
            parallelFor.WriteHeader();
            parallelFor.ExecuteTasks();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
