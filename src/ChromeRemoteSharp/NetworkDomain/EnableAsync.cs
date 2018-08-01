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
        /// Enables network tracking, network events will now be delivered to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#enable"/>
        /// </summary>
        /// <param name="maxTotalBufferSize">Buffer size in bytes to use when preserving network payloads (XHRs, etc).</param>
        /// <param name="maxResourceBufferSize">Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).</param>
        /// <param name="maxPostDataSize">Longest post body size (in bytes) that would be included in requestWillBeSent notification</param>
        /// <returns></returns>
        public async Task<JObject> EnableAsync(string maxTotalBufferSize,string maxResourceBufferSize,string maxPostDataSize)
        {
            return await CommandAsync("enable", 
                 new KeyValuePair<string, object>("maxTotalBufferSize", maxTotalBufferSize), 
                 new KeyValuePair<string, object>("maxResourceBufferSize", maxResourceBufferSize), 
                 new KeyValuePair<string, object>("maxPostDataSize", maxPostDataSize)
                 );
        }
    }
}
