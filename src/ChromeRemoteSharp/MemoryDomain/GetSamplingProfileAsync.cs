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
        /// Retrieve native memory allocations profile collected since last `startSampling` call.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#method-getSamplingProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetSamplingProfileAsync()
        {
            return await CommandAsync("getSamplingProfile");
        }
    }
}
