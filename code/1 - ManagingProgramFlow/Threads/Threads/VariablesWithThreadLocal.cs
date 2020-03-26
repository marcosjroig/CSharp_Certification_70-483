using System;
using System.Threading;

namespace Threads
{
    /// <summary>
    /// ThreadLocal helps to save a copy of a variable value for each thread. The difference with ThreadStatic is that the former one can be used also to initialize the value.
    /// </summary>
    public class VariablesWithThreadLocal
    {

        //It makes a local copy of the variable for each thread
        private ThreadLocal<int> GetSalary(int salaryIncrease)
        {
            var baseSalary = 100;
            var salary = baseSalary + salaryIncrease;


            return new ThreadLocal<int>(() => salary);
        }

        //Shared variable with all threads. I did it to show how this variable change when all the threads try to modify it. 
        public int Salary2 { get; set; } = 50;

        public void ExecuteTasks()
        {
            var t1 = new Thread(() =>
            {
                Console.WriteLine("t1: salary 1 {0}", GetSalary(5).Value);
                Salary2 += 5;
                Console.WriteLine("t1: salary 2 {0}", Salary2);
            });

            var t2 = new Thread(() =>
            {
                Console.WriteLine("t2: salary 1 {0}", GetSalary(10).Value);
                Salary2 += 20;
                Console.WriteLine("t2: salary 2 {0}", Salary2);
            });

            var t3 = new Thread(() =>
            {
                Salary2 += 1;
                Console.WriteLine("t3: salary 2 {0}", Salary2);
            });

            var t4 = new Thread(() =>
            {
                Salary2 += 2;
                Console.WriteLine("t4: salary 2 {0}", Salary2);
            });

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }
    }
}
