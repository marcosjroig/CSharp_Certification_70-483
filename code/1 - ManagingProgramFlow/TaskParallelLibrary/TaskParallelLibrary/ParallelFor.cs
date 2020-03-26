using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    public class ParallelFor
    {
        private void WorkOnItem(int itemId)
        {
            Console.WriteLine("Started work on " + itemId);
            Thread.Sleep(100);
            Console.WriteLine("Finished work on " + itemId);
        }

        public void WriteHeader()
        {
            Console.WriteLine("Parallel.For");
            Console.WriteLine("................");
        }

        public void ExecuteTasks()
        {
            var items = Enumerable.Range(0, 5).ToArray();
            Parallel.For(0, items.Length, i => 
            {
                 WorkOnItem(items[i]);
            });

            Console.WriteLine("");
        }
    }
}
