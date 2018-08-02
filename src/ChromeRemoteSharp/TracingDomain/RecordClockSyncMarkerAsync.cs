using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TracingDomain
{
    public partial class TracingDomain
    {
        /// <summary>
        /// Record a clock sync marker in the trace.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tracing#method-recordClockSyncMarker"/>
        /// </summary>
        /// <param name="syncId">The ID of this clock sync marker</param>
        /// <returns></returns>
        public async Task<JObject> RecordClockSyncMarkerAsync(string syncId)
        {
            return await CommandAsync("recordClockSyncMarker", 
                 new KeyValuePair<string, object>("syncId", syncId)
                 );
        }
    }
}
