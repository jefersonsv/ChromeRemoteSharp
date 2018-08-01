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
        /// Highlights owner element of the frame with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#highlightFrame"/>
        /// </summary>
        /// <param name="frameId">Identifier of the frame to highlight.</param>
        /// <param name="contentColor">The content box highlight fill color (default: transparent).</param>
        /// <param name="contentOutlineColor">The content box highlight outline color (default: transparent).</param>
        /// <returns></returns>
        public async Task<JObject> HighlightFrameAsync(string frameId,string contentColor,string contentOutlineColor)
        {
            return await CommandAsync("highlightFrame", 
                 new KeyValuePair<string, object>("frameId", frameId), 
                 new KeyValuePair<string, object>("contentColor", contentColor), 
                 new KeyValuePair<string, object>("contentOutlineColor", contentOutlineColor)
                 );
        }
    }
}
