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
        /// Returns all browser cookies for the current URL. Depending on the backend support, will return detailed cookie information in the `cookies` field.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-getCookies"/>
        /// </summary>
        /// <param name="urls">The list of URLs for which applicable cookies will be fetched</param>
        /// <returns></returns>
        public async Task<JObject> GetCookiesAsync(string[] urls = null)
        {
            return await CommandAsync("getCookies", 
                 new KeyValuePair<string, object>("urls", urls)
                 );
        }
    }
}
