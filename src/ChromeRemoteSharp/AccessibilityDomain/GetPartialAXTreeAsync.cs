using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.AccessibilityDomain
{
    public partial class AccessibilityDomain
    {
        /// <summary>
        /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Accessibility#method-getPartialAXTree"/>
        /// </summary>
        /// <param name="nodeId">Identifier of the node to get the partial accessibility tree for.</param>
        /// <param name="backendNodeId">Identifier of the backend node to get the partial accessibility tree for.</param>
        /// <param name="objectId">JavaScript object id of the node wrapper to get the partial accessibility tree for.</param>
        /// <param name="fetchRelatives">Whether to fetch this nodes ancestors, siblings and children. Defaults to true.</param>
        /// <returns></returns>
        public async Task<JObject> GetPartialAXTreeAsync(int nodeId, string backendNodeId = null, string objectId = null, bool? fetchRelatives = null)
        {
            return await CommandAsync("getPartialAXTree", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("backendNodeId", backendNodeId), 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("fetchRelatives", fetchRelatives)
                 );
        }
    }
}
