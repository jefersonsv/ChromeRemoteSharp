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
        /// Resolves the JavaScript node object for a given NodeId or BackendNodeId.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#resolveNode"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to resolve.</param>
        /// <param name="backendNodeId">Backend identifier of the node to resolve.</param>
        /// <param name="objectGroup">Symbolic group name that can be used to release multiple objects.</param>
        /// <returns></returns>
        public async Task<JObject> ResolveNodeAsync(string nodeId,string backendNodeId,string objectGroup)
        {
            return await CommandAsync("resolveNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("backendNodeId", backendNodeId), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup)
                 );
        }
    }
}
