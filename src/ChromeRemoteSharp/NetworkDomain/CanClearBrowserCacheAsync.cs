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
        /// Tells whether clearing browser cache is supported.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#canClearBrowserCache"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CanClearBrowserCacheAsync()
        {
            return await CommandAsync("canClearBrowserCache");
        }
    }
}
