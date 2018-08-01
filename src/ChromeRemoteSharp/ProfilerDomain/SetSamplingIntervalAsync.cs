using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ProfilerDomain
{
    public partial class ProfilerDomain
    {
        /// <summary>
        /// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#setSamplingInterval"/>
        /// </summary>
        /// <param name="interval">New sampling interval in microseconds.</param>
        /// <returns></returns>
        public async Task<JObject> SetSamplingIntervalAsync(string interval)
        {
            return await CommandAsync("setSamplingInterval", 
                 new KeyValuePair<string, object>("interval", interval)
                 );
        }
    }
}
