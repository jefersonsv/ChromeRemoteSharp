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
        /// Enable page Content Security Policy by-passing.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setBypassCSP"/>
        /// </summary>
        /// <param name="enabled">Whether to bypass page CSP.</param>
        /// <returns></returns>
        public async Task<JObject> SetBypassCSPAsync(bool enabled)
        {
            return await CommandAsync("setBypassCSP", 
                 new KeyValuePair<string, object>("enabled", enabled)
                 );
        }
    }
}
