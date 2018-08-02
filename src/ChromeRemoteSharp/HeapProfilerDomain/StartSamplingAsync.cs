using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.HeapProfilerDomain
{
    public partial class HeapProfilerDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#method-startSampling"/>
        /// </summary>
        /// <param name="samplingInterval">Average sample interval in bytes. Poisson distribution is used for the intervals. The default value is 32768 bytes.</param>
        /// <returns></returns>
        public async Task<JObject> StartSamplingAsync(int? samplingInterval = null)
        {
            return await CommandAsync("startSampling", 
                 new KeyValuePair<string, object>("samplingInterval", samplingInterval)
                 );
        }
    }
}
