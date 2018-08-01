using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.EmulationDomain
{
    public partial class EmulationDomain
    {
        /// <summary>
        /// Clears the overriden device metrics.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#clearDeviceMetricsOverride"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearDeviceMetricsOverrideAsync()
        {
            return await CommandAsync("clearDeviceMetricsOverride");
        }
    }
}
