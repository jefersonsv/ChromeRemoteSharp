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
        /// Clears browser cache.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#clearBrowserCache"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearBrowserCacheAsync()
        {
            return await CommandAsync("clearBrowserCache");
        }
    }
}
