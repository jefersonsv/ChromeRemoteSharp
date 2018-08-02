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
        /// Sets node name for a node with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-setNodeName"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to set name for.</param>
        /// <param name="name">New node's name.</param>
        /// <returns></returns>
        public async Task<JObject> SetNodeNameAsync(int nodeId, string name)
        {
            return await CommandAsync("setNodeName", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("name", name)
                 );
        }
    }
}
