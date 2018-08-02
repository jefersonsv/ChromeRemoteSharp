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
        /// Clears the overriden Geolocation Position and Error.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-clearGeolocationOverride"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearGeolocationOverrideAsync()
        {
            return await CommandAsync("clearGeolocationOverride");
        }
    }
}
