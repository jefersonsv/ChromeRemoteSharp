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
        /// Requests that backend shows debug borders on layers
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#method-setShowDebugBorders"/>
        /// </summary>
        /// <param name="show">True for showing debug borders</param>
        /// <returns></returns>
        public async Task<JObject> SetShowDebugBordersAsync(bool show)
        {
            return await CommandAsync("setShowDebugBorders", 
                 new KeyValuePair<string, object>("show", show)
                 );
        }
    }
}
