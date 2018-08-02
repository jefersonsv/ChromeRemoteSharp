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
        /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-setInspectedNode"/>
        /// </summary>
        /// <param name="nodeId">DOM node id to be accessible by means of $x command line API.</param>
        /// <returns></returns>
        public async Task<JObject> SetInspectedNodeAsync(int nodeId)
        {
            return await CommandAsync("setInspectedNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
