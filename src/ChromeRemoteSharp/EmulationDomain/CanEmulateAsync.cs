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
        /// Tells whether emulation is supported.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#method-canEmulate"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CanEmulateAsync()
        {
            return await CommandAsync("canEmulate");
        }
    }
}
