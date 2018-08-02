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
        /// Overrides value returned by the javascript navigator object.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-setNavigatorOverrides"/>
        /// </summary>
        /// <param name="platform">The platform navigator.platform should return.</param>
        /// <returns></returns>
        public async Task<JObject> SetNavigatorOverridesAsync(string platform)
        {
            return await CommandAsync("setNavigatorOverrides", 
                 new KeyValuePair<string, object>("platform", platform)
                 );
        }
    }
}
