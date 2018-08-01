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
        /// Describes node given its id, does not require domain to be enabled. Does not start tracking any objects, can be used for automation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#describeNode"/>
        /// </summary>
        /// <param name="nodeId">Identifier of the node.</param>
        /// <param name="backendNodeId">Identifier of the backend node.</param>
        /// <param name="objectId">JavaScript object id of the node wrapper.</param>
        /// <param name="depth">The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.</param>
        /// <param name="pierce">Whether or not iframes and shadow roots should be traversed when returning the subtree (default is false).</param>
        /// <returns></returns>
        public async Task<JObject> DescribeNodeAsync(string nodeId,string backendNodeId,string objectId,string depth,bool? pierce)
        {
            return await CommandAsync("describeNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("backendNodeId", backendNodeId), 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("depth", depth), 
                 new KeyValuePair<string, object>("pierce", pierce)
                 );
        }
    }
}
