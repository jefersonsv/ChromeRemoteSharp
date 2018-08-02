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
        /// Sets given cookies.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-setCookies"/>
        /// </summary>
        /// <param name="cookies">Cookies to be set.</param>
        /// <returns></returns>
        public async Task<JObject> SetCookiesAsync(string[] cookies)
        {
            return await CommandAsync("setCookies", 
                 new KeyValuePair<string, object>("cookies", cookies)
                 );
        }
    }
}
