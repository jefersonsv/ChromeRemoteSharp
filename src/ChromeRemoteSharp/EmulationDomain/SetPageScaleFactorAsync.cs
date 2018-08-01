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
        /// Sets a specified page scale factor.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setPageScaleFactor"/>
        /// </summary>
        /// <param name="pageScaleFactor">Page scale factor.</param>
        /// <returns></returns>
        public async Task<JObject> SetPageScaleFactorAsync(int pageScaleFactor)
        {
            return await CommandAsync("setPageScaleFactor", 
                 new KeyValuePair<string, object>("pageScaleFactor", pageScaleFactor)
                 );
        }
    }
}
