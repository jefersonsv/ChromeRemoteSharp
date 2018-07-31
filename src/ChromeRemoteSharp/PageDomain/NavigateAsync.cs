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
        /// <seealso cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-navigate"/>
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<JObject> NavigateAsync(Uri url)
        {
            return await CommandAsync("navigate", new KeyValuePair<string, string>("url", url.ToString()));
        }
    }
}
