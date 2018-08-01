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
        /// Returns boxes for the given node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#getBoxModel"/>
        /// </summary>
        /// <param name="nodeId">Identifier of the node.</param>
        /// <param name="backendNodeId">Identifier of the backend node.</param>
        /// <param name="objectId">JavaScript object id of the node wrapper.</param>
        /// <returns></returns>
        public async Task<JObject> GetBoxModelAsync(string nodeId,string backendNodeId,string objectId)
        {
            return await CommandAsync("getBoxModel", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("backendNodeId", backendNodeId), 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
