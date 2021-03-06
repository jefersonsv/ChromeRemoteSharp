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
        /// Executes `querySelector` on a given node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-querySelector"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to query upon.</param>
        /// <param name="selector">Selector string.</param>
        /// <returns></returns>
        public async Task<JObject> QuerySelectorAsync(int nodeId, string selector)
        {
            return await CommandAsync("querySelector", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("selector", selector)
                 );
        }
    }
}
