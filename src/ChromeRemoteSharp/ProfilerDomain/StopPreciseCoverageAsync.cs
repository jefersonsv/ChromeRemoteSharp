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
        /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows executing optimized code.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#stopPreciseCoverage"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopPreciseCoverageAsync()
        {
            return await CommandAsync("stopPreciseCoverage");
        }
    }
}
