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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#method-startTrackingHeapObjects"/>
        /// </summary>
        /// <param name="trackAllocations"></param>
        /// <returns></returns>
        public async Task<JObject> StartTrackingHeapObjectsAsync(bool? trackAllocations = null)
        {
            return await CommandAsync("startTrackingHeapObjects", 
                 new KeyValuePair<string, object>("trackAllocations", trackAllocations)
                 );
        }
    }
}
