using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.OverlayDomain
{
    public partial class OverlayDomain
    {
        /// <summary>
        /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#method-highlightNode"/>
        /// </summary>
        /// <param name="highlightConfig">A descriptor for the highlight appearance.</param>
        /// <param name="nodeId">Identifier of the node to highlight.</param>
        /// <param name="backendNodeId">Identifier of the backend node to highlight.</param>
        /// <param name="objectId">JavaScript object id of the node to be highlighted.</param>
        /// <returns></returns>
        public async Task<JObject> HighlightNodeAsync(string highlightConfig, int nodeId, string backendNodeId = null, string objectId = null)
        {
            return await CommandAsync("highlightNode", 
                 new KeyValuePair<string, object>("highlightConfig", highlightConfig), 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("backendNodeId", backendNodeId), 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
