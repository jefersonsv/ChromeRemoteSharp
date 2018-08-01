using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.OverlayDomain
{
    public partial class OverlayDomain
    {
        /// <summary>
        /// Requests that backend shows the FPS counter
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#setShowFPSCounter"/>
        /// </summary>
        /// <param name="show">True for showing the FPS counter</param>
        /// <returns></returns>
        public async Task<JObject> SetShowFPSCounterAsync(bool show)
        {
            return await CommandAsync("setShowFPSCounter", 
                 new KeyValuePair<string, object>("show", show)
                 );
        }
    }
}
