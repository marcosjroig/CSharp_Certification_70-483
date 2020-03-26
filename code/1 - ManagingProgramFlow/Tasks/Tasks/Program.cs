using System;

namespace Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Single Task
            var singleTask = new SingleTask();
            singleTask.ExecuteSingleTask();

            //Single task with result
            var singleTaskWithResult = new SingleTaskWithResult();
            var result = singleTaskWithResult.ExecuteSingleTask();
            Console.WriteLine("The result of the task is: " + result);

            //Task Array
            var taskArray = new TaskArray();
            taskArray.ExecuteTasks();

            //Continuation task
            var continuationTask = new ContinuationTask();
            continuationTask.ExecuteTasks();

            //ChildTask
            var childTask = new ChildTask();
            childTask.ExecuteTasks();

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
