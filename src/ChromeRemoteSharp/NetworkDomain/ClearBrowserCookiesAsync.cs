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
        /// Clears browser cookies.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#clearBrowserCookies"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearBrowserCookiesAsync()
        {
            return await CommandAsync("clearBrowserCookies");
        }
    }
}
