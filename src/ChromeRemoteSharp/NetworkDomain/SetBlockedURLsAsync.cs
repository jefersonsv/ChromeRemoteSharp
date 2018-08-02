using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// Blocks URLs from loading.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-setBlockedURLs"/>
        /// </summary>
        /// <param name="urls">URL patterns to block. Wildcards ('*') are allowed.</param>
        /// <returns></returns>
        public async Task<JObject> SetBlockedURLsAsync(string[] urls)
        {
            return await CommandAsync("setBlockedURLs", 
                 new KeyValuePair<string, object>("urls", urls)
                 );
        }
    }
}
