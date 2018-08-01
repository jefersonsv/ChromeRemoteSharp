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
        /// Sets node HTML markup, returns new node id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#setOuterHTML"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to set markup for.</param>
        /// <param name="outerHTML">Outer HTML markup to set.</param>
        /// <returns></returns>
        public async Task<JObject> SetOuterHTMLAsync(string nodeId,string outerHTML)
        {
            return await CommandAsync("setOuterHTML", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("outerHTML", outerHTML)
                 );
        }
    }
}
