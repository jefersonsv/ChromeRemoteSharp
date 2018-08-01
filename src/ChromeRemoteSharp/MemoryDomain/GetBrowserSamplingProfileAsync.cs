using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.MemoryDomain
{
    public partial class MemoryDomain
    {
        /// <summary>
        /// Retrieve native memory allocations profile collected since browser process startup.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#getBrowserSamplingProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetBrowserSamplingProfileAsync()
        {
            return await CommandAsync("getBrowserSamplingProfile");
        }
    }
}
