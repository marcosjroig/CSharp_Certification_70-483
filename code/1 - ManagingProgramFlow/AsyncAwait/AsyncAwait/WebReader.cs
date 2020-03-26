using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class WebReader
    {
        public async Task<IEnumerable<string>> FetchWebPagesAsync(List<string> urls)
        {
            Console.WriteLine("List of task STARTED reading webpages...");

            var tasks = new List<Task<string>>();
            foreach (var url in urls)
            {
                tasks.Add(FetchWebPage(url));
            }

            //WhenAll waits until all the task completes to return a value
            return await Task.WhenAll(tasks);
        }

        //Read one single page
        private async Task<string> FetchWebPage(string url)
        {
            var client = new HttpClient();
            var webContentStr = await client.GetStringAsync(url);

            return webContentStr;
        }
    }
}
