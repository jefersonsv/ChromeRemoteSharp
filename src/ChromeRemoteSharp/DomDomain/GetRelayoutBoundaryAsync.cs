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
        /// Returns the id of the nearest ancestor that is a relayout boundary.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#getRelayoutBoundary"/>
        /// </summary>
        /// <param name="nodeId">Id of the node.</param>
        /// <returns></returns>
        public async Task<JObject> GetRelayoutBoundaryAsync(string nodeId)
        {
            return await CommandAsync("getRelayoutBoundary", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
