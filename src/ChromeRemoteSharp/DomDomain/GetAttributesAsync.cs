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
        /// Returns attributes for the specified node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-getAttributes"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to retrieve attibutes for.</param>
        /// <returns></returns>
        public async Task<JObject> GetAttributesAsync(int nodeId)
        {
            return await CommandAsync("getAttributes", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
