using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain
    {
        /// <summary>
        /// Stop tracking rule usage and return the list of rules that were used since last call to `takeCoverageDelta` (or since start of coverage instrumentation)
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#stopRuleUsageTracking"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopRuleUsageTrackingAsync()
        {
            return await CommandAsync("stopRuleUsageTracking");
        }
    }
}
