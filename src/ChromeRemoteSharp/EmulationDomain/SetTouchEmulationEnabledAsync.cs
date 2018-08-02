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
        /// Enables touch on platforms which do not support them.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-setTouchEmulationEnabled"/>
        /// </summary>
        /// <param name="enabled">Whether the touch event emulation should be enabled.</param>
        /// <param name="maxTouchPoints">Maximum touch points supported. Defaults to one.</param>
        /// <returns></returns>
        public async Task<JObject> SetTouchEmulationEnabledAsync(bool enabled, string maxTouchPoints = null)
        {
            return await CommandAsync("setTouchEmulationEnabled", 
                 new KeyValuePair<string, object>("enabled", enabled), 
                 new KeyValuePair<string, object>("maxTouchPoints", maxTouchPoints)
                 );
        }
    }
}
