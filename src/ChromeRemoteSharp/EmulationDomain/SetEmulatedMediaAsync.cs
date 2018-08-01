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
        /// Emulates the given media for CSS media queries.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setEmulatedMedia"/>
        /// </summary>
        /// <param name="media">Media type to emulate. Empty string disables the override.</param>
        /// <returns></returns>
        public async Task<JObject> SetEmulatedMediaAsync(string media)
        {
            return await CommandAsync("setEmulatedMedia", 
                 new KeyValuePair<string, object>("media", media)
                 );
        }
    }
}
