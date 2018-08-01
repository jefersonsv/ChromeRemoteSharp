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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#stopTrackingHeapObjects"/>
        /// </summary>
        /// <param name="reportProgress">If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken when the tracking is stopped.</param>
        /// <returns></returns>
        public async Task<JObject> StopTrackingHeapObjectsAsync(bool? reportProgress)
        {
            return await CommandAsync("stopTrackingHeapObjects", 
                 new KeyValuePair<string, object>("reportProgress", reportProgress)
                 );
        }
    }
}
