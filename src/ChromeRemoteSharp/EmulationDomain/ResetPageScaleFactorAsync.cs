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
        /// Requests that page scale factor is reset to initial values.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#resetPageScaleFactor"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ResetPageScaleFactorAsync()
        {
            return await CommandAsync("resetPageScaleFactor");
        }
    }
}
