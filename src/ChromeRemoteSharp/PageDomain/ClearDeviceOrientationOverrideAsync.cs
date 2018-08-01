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
        /// Clears the overridden Device Orientation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#clearDeviceOrientationOverride"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearDeviceOrientationOverrideAsync()
        {
            return await CommandAsync("clearDeviceOrientationOverride");
        }
    }
}
