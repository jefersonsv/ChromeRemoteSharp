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
        /// Returns content served for the given request.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#getResponseBody"/>
        /// </summary>
        /// <param name="requestId">Identifier of the network request to get content for.</param>
        /// <returns></returns>
        public async Task<JObject> GetResponseBodyAsync(string requestId)
        {
            return await CommandAsync("getResponseBody", 
                 new KeyValuePair<string, object>("requestId", requestId)
                 );
        }
    }
}
