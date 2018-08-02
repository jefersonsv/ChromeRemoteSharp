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
        /// Returns content of the given resource.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-getResourceContent"/>
        /// </summary>
        /// <param name="frameId">Frame id to get resource for.</param>
        /// <param name="url">URL of the resource to get content for.</param>
        /// <returns></returns>
        public async Task<JObject> GetResourceContentAsync(string frameId, string url)
        {
            return await CommandAsync("getResourceContent", 
                 new KeyValuePair<string, object>("frameId", frameId), 
                 new KeyValuePair<string, object>("url", url)
                 );
        }
    }
}
