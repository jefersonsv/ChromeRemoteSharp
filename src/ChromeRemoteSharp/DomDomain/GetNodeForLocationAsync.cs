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
        /// Returns node id at given location.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-getNodeForLocation"/>
        /// </summary>
        /// <param name="x">X coordinate.</param>
        /// <param name="y">Y coordinate.</param>
        /// <param name="includeUserAgentShadowDOM">False to skip to the nearest non-UA shadow root ancestor (default: false).</param>
        /// <returns></returns>
        public async Task<JObject> GetNodeForLocationAsync(string x, string y, bool? includeUserAgentShadowDOM = null)
        {
            return await CommandAsync("getNodeForLocation", 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("includeUserAgentShadowDOM", includeUserAgentShadowDOM)
                 );
        }
    }
}
