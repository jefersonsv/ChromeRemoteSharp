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
        /// Sets node value for a node with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-setNodeValue"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to set value for.</param>
        /// <param name="value">New node's value.</param>
        /// <returns></returns>
        public async Task<JObject> SetNodeValueAsync(int nodeId, string value)
        {
            return await CommandAsync("setNodeValue", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("value", value)
                 );
        }
    }
}
