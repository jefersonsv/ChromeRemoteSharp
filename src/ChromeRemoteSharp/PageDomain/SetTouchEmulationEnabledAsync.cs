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
        /// Toggles mouse event-based touch event emulation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setTouchEmulationEnabled"/>
        /// </summary>
        /// <param name="enabled">Whether the touch event emulation should be enabled.</param>
        /// <param name="configuration">Touch/gesture events configuration. Default: current platform.</param>
        /// <returns></returns>
        public async Task<JObject> SetTouchEmulationEnabledAsync(bool enabled, string configuration = null)
        {
            return await CommandAsync("setTouchEmulationEnabled", 
                 new KeyValuePair<string, object>("enabled", enabled), 
                 new KeyValuePair<string, object>("configuration", configuration)
                 );
        }
    }
}
