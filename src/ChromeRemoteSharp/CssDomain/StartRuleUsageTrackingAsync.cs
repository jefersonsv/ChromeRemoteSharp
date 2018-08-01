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
        /// Enables the selector recording.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css#startRuleUsageTracking"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StartRuleUsageTrackingAsync()
        {
            return await CommandAsync("startRuleUsageTracking");
        }
    }
}
