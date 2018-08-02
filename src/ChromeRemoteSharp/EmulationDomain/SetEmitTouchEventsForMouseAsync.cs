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
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-setEmitTouchEventsForMouse"/>
        /// </summary>
        /// <param name="enabled">Whether touch emulation based on mouse input should be enabled.</param>
        /// <param name="configuration">Touch/gesture events configuration. Default: current platform.</param>
        /// <returns></returns>
        public async Task<JObject> SetEmitTouchEventsForMouseAsync(bool enabled, string configuration = null)
        {
            return await CommandAsync("setEmitTouchEventsForMouse", 
                 new KeyValuePair<string, object>("enabled", enabled), 
                 new KeyValuePair<string, object>("configuration", configuration)
                 );
        }
    }
}
