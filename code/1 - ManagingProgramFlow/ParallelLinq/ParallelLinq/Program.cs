using System;
using System.Linq;
using ParallelLinq.Model;

namespace ParallelLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Persons().List;

            //AsParallel
            var result1 = from person in persons.AsParallel()
                          where person.City == "Seattle"
                          select person;

            Messages.SeattleMsg();
            var showResult = new ShowResult();
            showResult.WriteConsoleMessage(result1);

            //Parallelism options
            var result2 = from person in persons.AsParallel().
                            WithDegreeOfParallelism(4). //Maximum 4 tasks in parallel
                            WithExecutionMode(ParallelExecutionMode.ForceParallelism) //enforce the parallelism
                          where person.City == "London"
                          select person;

            Messages.LondonMsg();
            showResult.WriteConsoleMessage(result2);

            //Using AsOrdered to preserve data ordering
            var result3 = from person in persons.AsParallel().AsOrdered()
                          where person.City == "Seattle"
                          select person;

            Messages.SeattleMsg();
            showResult.WriteConsoleMessage(result3);

            //Execution of the query using AsSequencial
            var result4 = (from person in persons.AsParallel()
                          where person.City == "Seattle"
                          orderby (person.Name)
                          select new Person
                          {
                              Name = person.Name
                          }).AsSequential().Take(4);

            Messages.SeattleMsg();
            showResult.WriteConsoleMessage(result4);

            //ForAll
            var result5 = from person in persons.AsParallel()
                          where person.City == "Seattle"
                          select person;
            result5.ForAll(person => Console.WriteLine(person.Name)); //It start before the query completes

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
