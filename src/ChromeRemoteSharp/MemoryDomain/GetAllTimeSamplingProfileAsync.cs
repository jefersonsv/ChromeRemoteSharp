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
        /// Retrieve native memory allocations profile collected since renderer process startup.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#getAllTimeSamplingProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetAllTimeSamplingProfileAsync()
        {
            return await CommandAsync("getAllTimeSamplingProfile");
        }
    }
}
