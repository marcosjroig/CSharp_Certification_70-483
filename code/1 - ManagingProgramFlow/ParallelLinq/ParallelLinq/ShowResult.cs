using ParallelLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParallelLinq
{
    public class ShowResult
    {
        public void WriteConsoleMessage(ParallelQuery<Person> persons)
        {
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("");
        }

        public void WriteConsoleMessage(IEnumerable<Person> persons)
        {
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("");
        }
    }
}
