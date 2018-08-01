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
        /// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by `nodeId`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#getInlineStylesForNode"/>
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task<JObject> GetInlineStylesForNodeAsync(string nodeId)
        {
            return await CommandAsync("getInlineStylesForNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
