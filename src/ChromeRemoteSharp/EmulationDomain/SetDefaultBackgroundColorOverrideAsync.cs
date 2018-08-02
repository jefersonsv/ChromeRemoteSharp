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
        /// Sets or clears an override of the default background color of the frame. This override is used if the content does not specify one.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-setDefaultBackgroundColorOverride"/>
        /// </summary>
        /// <param name="color">RGBA of the default background color. If not specified, any existing override will be cleared.</param>
        /// <returns></returns>
        public async Task<JObject> SetDefaultBackgroundColorOverrideAsync(string color = null)
        {
            return await CommandAsync("setDefaultBackgroundColorOverride", 
                 new KeyValuePair<string, object>("color", color)
                 );
        }
    }
}
