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
        /// Collect coverage data for the current isolate, and resets execution counters. Precise code coverage needs to have started.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#takePreciseCoverage"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> TakePreciseCoverageAsync()
        {
            return await CommandAsync("takePreciseCoverage");
        }
    }
}
