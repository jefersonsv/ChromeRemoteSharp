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
        /// Collects class names for the node with given id and all of it's child nodes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-collectClassNamesFromSubtree"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to collect class names.</param>
        /// <returns></returns>
        public async Task<JObject> CollectClassNamesFromSubtreeAsync(int nodeId)
        {
            return await CommandAsync("collectClassNamesFromSubtree", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
