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
        /// Clears the overriden Geolocation Position and Error.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-clearGeolocationOverride"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearGeolocationOverrideAsync()
        {
            return await CommandAsync("clearGeolocationOverride");
        }
    }
}
