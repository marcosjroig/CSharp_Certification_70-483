using System;

namespace AsyncAwait
{
    /// <summary>
    /// Awaiting parallel tasks
    /// </summary>
    public class AsyncAwaitForListOfTasks
    {
        public async void ExecuteTask()
        {
            var urls = UrlList.SetUpUrlList();
            var webReader = new WebReader();

            //Get the content of all the pages
            var webContents = await webReader.FetchWebPagesAsync(urls);

            Console.WriteLine("List of task FINISHED reading webpages...");

            foreach (var pageStr in webContents)
            {
                Console.WriteLine("");
                Console.WriteLine(pageStr.Truncate(10));
            }
        }
    }
}
