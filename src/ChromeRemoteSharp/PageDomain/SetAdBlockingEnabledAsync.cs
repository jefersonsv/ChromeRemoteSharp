using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Enable Chrome's experimental ad filter on all sites.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setAdBlockingEnabled"/>
        /// </summary>
        /// <param name="enabled">Whether to block ads.</param>
        /// <returns></returns>
        public async Task<JObject> SetAdBlockingEnabledAsync(bool enabled)
        {
            return await CommandAsync("setAdBlockingEnabled", 
                 new KeyValuePair<string, object>("enabled", enabled)
                 );
        }
    }
}
