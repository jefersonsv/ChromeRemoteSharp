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
        /// Stop collecting native memory profile.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#method-stopSampling"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopSamplingAsync()
        {
            return await CommandAsync("stopSampling");
        }
    }
}
