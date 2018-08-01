using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// Tells whether clearing browser cookies is supported.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#canClearBrowserCookies"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CanClearBrowserCookiesAsync()
        {
            return await CommandAsync("canClearBrowserCookies");
        }
    }
}
