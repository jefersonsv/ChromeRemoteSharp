using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Clears the overriden device metrics.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-clearDeviceMetricsOverride"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearDeviceMetricsOverrideAsync()
        {
            return await CommandAsync("clearDeviceMetricsOverride");
        }
    }
}
