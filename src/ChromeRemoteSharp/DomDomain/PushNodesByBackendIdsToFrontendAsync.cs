using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// Requests that a batch of nodes is sent to the caller given their backend node ids.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-pushNodesByBackendIdsToFrontend"/>
        /// </summary>
        /// <param name="backendNodeIds">The array of backend node ids.</param>
        /// <returns></returns>
        public async Task<JObject> PushNodesByBackendIdsToFrontendAsync(string[] backendNodeIds)
        {
            return await CommandAsync("pushNodesByBackendIdsToFrontend", 
                 new KeyValuePair<string, object>("backendNodeIds", backendNodeIds)
                 );
        }
    }
}
