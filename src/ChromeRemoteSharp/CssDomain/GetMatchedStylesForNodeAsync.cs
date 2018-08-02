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
        /// Returns requested styles for a DOM node identified by `nodeId`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-getMatchedStylesForNode"/>
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task<JObject> GetMatchedStylesForNodeAsync(int nodeId)
        {
            return await CommandAsync("getMatchedStylesForNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
