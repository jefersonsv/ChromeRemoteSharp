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
        /// Removes node with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-removeNode"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to remove.</param>
        /// <returns></returns>
        public async Task<JObject> RemoveNodeAsync(int nodeId)
        {
            return await CommandAsync("removeNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
