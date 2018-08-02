using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain
    {
        /// <summary>
        /// Returns the computed style for a DOM node identified by `nodeId`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-getComputedStyleForNode"/>
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task<JObject> GetComputedStyleForNodeAsync(int nodeId)
        {
            return await CommandAsync("getComputedStyleForNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
