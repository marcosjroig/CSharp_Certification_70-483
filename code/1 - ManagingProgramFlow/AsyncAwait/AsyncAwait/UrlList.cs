using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait
{
    public static class UrlList
    {
        public static List<string> SetUpUrlList()
        {
            var urls = new List<string>
            {
                "https://msdn.microsoft.com",
                "https://google.com",
                "https://www.waiverking.com"
            };

            return urls;
        }
    }
}
