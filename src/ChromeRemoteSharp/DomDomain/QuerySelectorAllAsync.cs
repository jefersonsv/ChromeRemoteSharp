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
        /// Executes `querySelectorAll` on a given node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-querySelectorAll"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to query upon.</param>
        /// <param name="selector">Selector string.</param>
        /// <returns></returns>
        public async Task<JObject> QuerySelectorAllAsync(int nodeId, string selector)
        {
            return await CommandAsync("querySelectorAll", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("selector", selector)
                 );
        }
    }
}
