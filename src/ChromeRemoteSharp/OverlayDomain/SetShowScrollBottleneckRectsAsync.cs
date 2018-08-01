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
        /// Requests that backend shows scroll bottleneck rects
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#setShowScrollBottleneckRects"/>
        /// </summary>
        /// <param name="show">True for showing scroll bottleneck rects</param>
        /// <returns></returns>
        public async Task<JObject> SetShowScrollBottleneckRectsAsync(bool show)
        {
            return await CommandAsync("setShowScrollBottleneckRects", 
                 new KeyValuePair<string, object>("show", show)
                 );
        }
    }
}
