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
        /// Paints viewport size upon main frame resize.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#method-setShowViewportSizeOnResize"/>
        /// </summary>
        /// <param name="show">Whether to paint size or not.</param>
        /// <returns></returns>
        public async Task<JObject> SetShowViewportSizeOnResizeAsync(bool show)
        {
            return await CommandAsync("setShowViewportSizeOnResize", 
                 new KeyValuePair<string, object>("show", show)
                 );
        }
    }
}
