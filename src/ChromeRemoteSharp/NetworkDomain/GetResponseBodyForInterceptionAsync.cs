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
        /// Returns content served for the given currently intercepted request.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#getResponseBodyForInterception"/>
        /// </summary>
        /// <param name="interceptionId">Identifier for the intercepted request to get body for.</param>
        /// <returns></returns>
        public async Task<JObject> GetResponseBodyForInterceptionAsync(string interceptionId)
        {
            return await CommandAsync("getResponseBodyForInterception", 
                 new KeyValuePair<string, object>("interceptionId", interceptionId)
                 );
        }
    }
}
