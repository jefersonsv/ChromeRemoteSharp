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
        /// Moves node into the new container, places it before the given anchor.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#moveTo"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to move.</param>
        /// <param name="targetNodeId">Id of the element to drop the moved node into.</param>
        /// <param name="insertBeforeNodeId">Drop node before this one (if absent, the moved node becomes the last child of `targetNodeId`).</param>
        /// <returns></returns>
        public async Task<JObject> MoveToAsync(string nodeId,string targetNodeId,string insertBeforeNodeId)
        {
            return await CommandAsync("moveTo", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("targetNodeId", targetNodeId), 
                 new KeyValuePair<string, object>("insertBeforeNodeId", insertBeforeNodeId)
                 );
        }
    }
}
