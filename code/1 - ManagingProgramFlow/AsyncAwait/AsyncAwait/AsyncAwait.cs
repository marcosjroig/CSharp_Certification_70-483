using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AsyncAwait
    {
        private async Task<int> DoSomethingAsync()
        {
            Console.WriteLine("Delay 2 seconds");

            //The execution of this method will stop here and return to to main thread.
            //When the task finishes, it will back here and continuos with the following line after the await
            await Task.Delay(2000);
            return 25;
        }

        public async void ExecuteTask()
        {
            var result = await DoSomethingAsync();
            Console.WriteLine("the result is {0}", result);
        }
    }
}
