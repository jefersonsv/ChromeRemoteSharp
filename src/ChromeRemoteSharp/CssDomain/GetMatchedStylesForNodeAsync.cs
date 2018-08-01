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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#getMatchedStylesForNode"/>
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task<JObject> GetMatchedStylesForNodeAsync(string nodeId)
        {
            return await CommandAsync("getMatchedStylesForNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
