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
        /// Start collecting native memory profile.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#method-startSampling"/>
        /// </summary>
        /// <param name="samplingInterval">Average number of bytes between samples.</param>
        /// <param name="suppressRandomness">Do not randomize intervals between samples.</param>
        /// <returns></returns>
        public async Task<JObject> StartSamplingAsync(string samplingInterval = null, bool? suppressRandomness = null)
        {
            return await CommandAsync("startSampling", 
                 new KeyValuePair<string, object>("samplingInterval", samplingInterval), 
                 new KeyValuePair<string, object>("suppressRandomness", suppressRandomness)
                 );
        }
    }
}
