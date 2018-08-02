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
        /// Specifies whether to always send extra HTTP headers with the requests from this page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-setExtraHTTPHeaders"/>
        /// </summary>
        /// <param name="headers">Map with extra HTTP headers.</param>
        /// <returns></returns>
        public async Task<JObject> SetExtraHTTPHeadersAsync(string headers)
        {
            return await CommandAsync("setExtraHTTPHeaders", 
                 new KeyValuePair<string, object>("headers", headers)
                 );
        }
    }
}
