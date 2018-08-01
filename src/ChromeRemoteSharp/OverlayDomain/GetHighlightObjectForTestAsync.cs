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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#getHighlightObjectForTest"/>
        /// </summary>
        /// <param name="nodeId">Id of the node to get highlight object for.</param>
        /// <returns></returns>
        public async Task<JObject> GetHighlightObjectForTestAsync(string nodeId)
        {
            return await CommandAsync("getHighlightObjectForTest", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
