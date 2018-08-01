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
        /// Enables CPU throttling to emulate slow CPUs.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setCPUThrottlingRate"/>
        /// </summary>
        /// <param name="rate">Throttling rate as a slowdown factor (1 is no throttle, 2 is 2x slowdown, etc).</param>
        /// <returns></returns>
        public async Task<JObject> SetCPUThrottlingRateAsync(int rate)
        {
            return await CommandAsync("setCPUThrottlingRate", 
                 new KeyValuePair<string, object>("rate", rate)
                 );
        }
    }
}
