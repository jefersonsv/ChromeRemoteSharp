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
        /// Requests information about platform fonts which we used to render child TextNodes in the given node.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#getPlatformFontsForNode"/>
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public async Task<JObject> GetPlatformFontsForNodeAsync(string nodeId)
        {
            return await CommandAsync("getPlatformFontsForNode", 
                 new KeyValuePair<string, object>("nodeId", nodeId)
                 );
        }
    }
}
