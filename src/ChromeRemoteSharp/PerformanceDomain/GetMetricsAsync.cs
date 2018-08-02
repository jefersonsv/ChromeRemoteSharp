using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PerformanceDomain
{
    public partial class PerformanceDomain
    {
        /// <summary>
        /// Retrieve current values of run-time metrics.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Performance#method-getMetrics"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetMetricsAsync()
        {
            return await CommandAsync("getMetrics");
        }
    }
}
