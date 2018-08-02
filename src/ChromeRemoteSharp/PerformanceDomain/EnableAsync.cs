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
        /// Enable collecting and reporting metrics.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Performance#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
