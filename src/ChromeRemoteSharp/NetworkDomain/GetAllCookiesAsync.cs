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
        /// Returns all browser cookies. Depending on the backend support, will return detailed cookie information in the `cookies` field.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#getAllCookies"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetAllCookiesAsync()
        {
            return await CommandAsync("getAllCookies");
        }
    }
}
