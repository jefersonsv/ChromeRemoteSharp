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
        /// Allows overriding user agent with the given string.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#setUserAgentOverride"/>
        /// </summary>
        /// <param name="userAgent">User agent to use.</param>
        /// <param name="acceptLanguage">Browser langugage to emulate.</param>
        /// <param name="platform">The platform navigator.platform should return.</param>
        /// <returns></returns>
        public async Task<JObject> SetUserAgentOverrideAsync(string userAgent,string acceptLanguage,string platform)
        {
            return await CommandAsync("setUserAgentOverride", 
                 new KeyValuePair<string, object>("userAgent", userAgent), 
                 new KeyValuePair<string, object>("acceptLanguage", acceptLanguage), 
                 new KeyValuePair<string, object>("platform", platform)
                 );
        }
    }
}
