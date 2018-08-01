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
        /// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#replayXHR"/>
        /// </summary>
        /// <param name="requestId">Identifier of XHR to replay.</param>
        /// <returns></returns>
        public async Task<JObject> ReplayXHRAsync(string requestId)
        {
            return await CommandAsync("replayXHR", 
                 new KeyValuePair<string, object>("requestId", requestId)
                 );
        }
    }
}
