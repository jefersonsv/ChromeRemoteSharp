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
        /// Activates emulation of network conditions.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#emulateNetworkConditions"/>
        /// </summary>
        /// <param name="offline">True to emulate internet disconnection.</param>
        /// <param name="latency">Minimum latency from request sent to response headers received (ms).</param>
        /// <param name="downloadThroughput">Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.</param>
        /// <param name="uploadThroughput">Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.</param>
        /// <param name="connectionType">Connection type if known.</param>
        /// <returns></returns>
        public async Task<JObject> EmulateNetworkConditionsAsync(bool offline,int latency,int downloadThroughput,int uploadThroughput,string connectionType)
        {
            return await CommandAsync("emulateNetworkConditions", 
                 new KeyValuePair<string, object>("offline", offline), 
                 new KeyValuePair<string, object>("latency", latency), 
                 new KeyValuePair<string, object>("downloadThroughput", downloadThroughput), 
                 new KeyValuePair<string, object>("uploadThroughput", uploadThroughput), 
                 new KeyValuePair<string, object>("connectionType", connectionType)
                 );
        }
    }
}
