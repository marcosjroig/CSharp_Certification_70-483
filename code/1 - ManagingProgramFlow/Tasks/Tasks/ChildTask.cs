using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class ChildTask
    {
        private void DoChild(object taskId)
        {
            Console.WriteLine("Child {0} starting", taskId);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finished", taskId);
        }

        public void ExecuteTasks()
        {
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent task starting...");
                Console.WriteLine("");

                for (var i = 0; i < 10; i++)
                {
                    var taskNro = i;
                    Task.Factory.StartNew(DoChild, taskNro,TaskCreationOptions.AttachedToParent);
                }
            });

            parent.Wait(); //will wait for all the attached children to complete

            Console.WriteLine("");
            Console.WriteLine("Parent finished!");
            Console.WriteLine("");
        }
    }
}
