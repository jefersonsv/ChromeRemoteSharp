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
        /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#highlightQuad"/>
        /// </summary>
        /// <param name="quad">Quad to highlight</param>
        /// <param name="color">The highlight fill color (default: transparent).</param>
        /// <param name="outlineColor">The highlight outline color (default: transparent).</param>
        /// <returns></returns>
        public async Task<JObject> HighlightQuadAsync(string quad,string color,string outlineColor)
        {
            return await CommandAsync("highlightQuad", 
                 new KeyValuePair<string, object>("quad", quad), 
                 new KeyValuePair<string, object>("color", color), 
                 new KeyValuePair<string, object>("outlineColor", outlineColor)
                 );
        }
    }
}
