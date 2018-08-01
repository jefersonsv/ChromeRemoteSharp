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
        /// Toggles ignoring cache for each request. If `true`, cache will not be used.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#setCacheDisabled"/>
        /// </summary>
        /// <param name="cacheDisabled">Cache disabled state.</param>
        /// <returns></returns>
        public async Task<JObject> SetCacheDisabledAsync(bool cacheDisabled)
        {
            return await CommandAsync("setCacheDisabled", 
                 new KeyValuePair<string, object>("cacheDisabled", cacheDisabled)
                 );
        }
    }
}
