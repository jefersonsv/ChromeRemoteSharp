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
        /// Returns post data sent with the request. Returns an error when no data was sent with the request.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#getRequestPostData"/>
        /// </summary>
        /// <param name="requestId">Identifier of the network request to get content for.</param>
        /// <returns></returns>
        public async Task<JObject> GetRequestPostDataAsync(string requestId)
        {
            return await CommandAsync("getRequestPostData", 
                 new KeyValuePair<string, object>("requestId", requestId)
                 );
        }
    }
}
