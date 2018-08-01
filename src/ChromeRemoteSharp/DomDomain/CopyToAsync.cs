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
        /// Creates a deep copy of the specified node and places it into the target container before the given anchor.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#copyTo"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to copy.</param>
        /// <param name="targetNodeId">Id of the element to drop the copy into.</param>
        /// <param name="insertBeforeNodeId">Drop the copy before this node (if absent, the copy becomes the last child of `targetNodeId`).</param>
        /// <returns></returns>
        public async Task<JObject> CopyToAsync(string nodeId,string targetNodeId,string insertBeforeNodeId)
        {
            return await CommandAsync("copyTo", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("targetNodeId", targetNodeId), 
                 new KeyValuePair<string, object>("insertBeforeNodeId", insertBeforeNodeId)
                 );
        }
    }
}
