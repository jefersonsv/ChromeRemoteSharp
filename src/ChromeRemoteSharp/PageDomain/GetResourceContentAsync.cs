using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// <seealso cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-getResourceContent"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetResourceContentAsync(string frameId, string url)
        {
            return await CommandAsync("getResourceContent",
                new KeyValuePair<string, string>("frameId", frameId),
                new KeyValuePair<string, string>("url", url)
                );
        }
    }
}
