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
        /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code coverage may be incomplete. Enabling prevents running optimized code and resets execution counters.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#method-startPreciseCoverage"/>
        /// </summary>
        /// <param name="callCount">Collect accurate call counts beyond simple 'covered' or 'not covered'.</param>
        /// <param name="detailed">Collect block-based coverage.</param>
        /// <returns></returns>
        public async Task<JObject> StartPreciseCoverageAsync(bool? callCount = null, bool? detailed = null)
        {
            return await CommandAsync("startPreciseCoverage", 
                 new KeyValuePair<string, object>("callCount", callCount), 
                 new KeyValuePair<string, object>("detailed", detailed)
                 );
        }
    }
}
