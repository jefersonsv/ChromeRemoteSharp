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
        /// Toggles ignoring of service worker for each request.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-setBypassServiceWorker"/>
        /// </summary>
        /// <param name="bypass">Bypass service worker and load from network.</param>
        /// <returns></returns>
        public async Task<JObject> SetBypassServiceWorkerAsync(bool bypass)
        {
            return await CommandAsync("setBypassServiceWorker", 
                 new KeyValuePair<string, object>("bypass", bypass)
                 );
        }
    }
}
