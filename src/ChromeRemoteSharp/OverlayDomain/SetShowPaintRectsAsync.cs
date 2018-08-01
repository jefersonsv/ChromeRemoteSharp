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
        /// Requests that backend shows paint rectangles
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#setShowPaintRects"/>
        /// </summary>
        /// <param name="result">True for showing paint rectangles</param>
        /// <returns></returns>
        public async Task<JObject> SetShowPaintRectsAsync(bool result)
        {
            return await CommandAsync("setShowPaintRects", 
                 new KeyValuePair<string, object>("result", result)
                 );
        }
    }
}
