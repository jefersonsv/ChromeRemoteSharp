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
        /// Sets the requests to intercept that match a the provided patterns and optionally resource types.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#setRequestInterception"/>
        /// </summary>
        /// <param name="patterns">Requests matching any of these patterns will be forwarded and wait for the corresponding continueInterceptedRequest call.</param>
        /// <returns></returns>
        public async Task<JObject> SetRequestInterceptionAsync(string[] patterns)
        {
            return await CommandAsync("setRequestInterception", 
                 new KeyValuePair<string, object>("patterns", patterns)
                 );
        }
    }
}
