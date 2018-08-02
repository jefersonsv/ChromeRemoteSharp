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
        /// Requests that children of the node with given id are returned to the caller in form of `setChildNodes` events where not only immediate children are retrieved, but all children down to the specified depth.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-requestChildNodes"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to get children for.</param>
        /// <param name="depth">The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the entire subtree or provide an integer larger than 0.</param>
        /// <param name="pierce">Whether or not iframes and shadow roots should be traversed when returning the sub-tree (default is false).</param>
        /// <returns></returns>
        public async Task<JObject> RequestChildNodesAsync(int nodeId, string depth = null, bool? pierce = null)
        {
            return await CommandAsync("requestChildNodes", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("depth", depth), 
                 new KeyValuePair<string, object>("pierce", pierce)
                 );
        }
    }
}
