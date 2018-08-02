using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.OverlayDomain
{
    public partial class OverlayDomain
    {
        /// <summary>
        /// For testing.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#method-getHighlightObjectForTest"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to get highlight object for.</param>
        /// <returns></returns>
        public async Task<JObject> GetHighlightObjectForTestAsync(int nodeId)
        {
            return await CommandAsync("getHighlightObjectForTest", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
