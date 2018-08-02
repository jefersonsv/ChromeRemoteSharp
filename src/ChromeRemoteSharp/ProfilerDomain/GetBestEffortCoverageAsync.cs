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
        /// Collect coverage data for the current isolate. The coverage data may be incomplete due to garbage collection.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#method-getBestEffortCoverage"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetBestEffortCoverageAsync()
        {
            return await CommandAsync("getBestEffortCoverage");
        }
    }
}
