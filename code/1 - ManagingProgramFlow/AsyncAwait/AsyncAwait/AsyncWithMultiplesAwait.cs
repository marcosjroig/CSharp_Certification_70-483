using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncWithMultiplesAwait
    {
        private async Task<int> DoWorkAsync(string taskDesc)
        {
            Console.WriteLine("Starting task {0}", taskDesc);
            await Task.Delay(2000);
            Console.WriteLine("finished task {0}", taskDesc);
            return 25;
        }

        public async void ExecuteTask()
        {
            var resultTask1 = await DoWorkAsync("Task1");

            Thread.Sleep(2000);

            var resultTask2 = await DoWorkAsync("Task2");

            Thread.Sleep(2000);

            var resultTask3 = await DoWorkAsync("Task3");

            Thread.Sleep(2000);

            var resultTask4 = await DoWorkAsync("Task4");

            Thread.Sleep(2000);

            var resultTask5 = await DoWorkAsync("Task5");

            Thread.Sleep(2000);

            Console.WriteLine("");
            Console.WriteLine("All TASK Executed!!!");
            Console.WriteLine("Final result is: " + resultTask1 + resultTask2 + resultTask3 + resultTask4 + resultTask5);
        }
    }
}
