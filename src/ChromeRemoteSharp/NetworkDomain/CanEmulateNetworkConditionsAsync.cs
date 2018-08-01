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
        /// Tells whether emulation of network conditions is supported.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#canEmulateNetworkConditions"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CanEmulateNetworkConditionsAsync()
        {
            return await CommandAsync("canEmulateNetworkConditions");
        }
    }
}
