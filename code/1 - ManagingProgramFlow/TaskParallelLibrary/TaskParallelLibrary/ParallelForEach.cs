using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    public class ParallelForEach
    {
        private void WorkOnItem(int itemId)
        {
            Console.WriteLine("Started work on " + itemId);
            Thread.Sleep(100);
            Console.WriteLine("Finished work on " + itemId);
        }

        public void WriteHeader()
        {
            Console.WriteLine("Parallel.ForEach");
            Console.WriteLine("................");
        }

        public void ExecuteTasks()
        {
            var items = Enumerable.Range(0, 5);
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });
            Console.WriteLine("");
        }
    }
}
