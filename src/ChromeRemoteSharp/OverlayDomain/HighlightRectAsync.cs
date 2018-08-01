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
        /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#highlightRect"/>
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="width">Rectangle width</param>
        /// <param name="height">Rectangle height</param>
        /// <param name="color">The highlight fill color (default: transparent).</param>
        /// <param name="outlineColor">The highlight outline color (default: transparent).</param>
        /// <returns></returns>
        public async Task<JObject> HighlightRectAsync(string x,string y,string width,string height,string color,string outlineColor)
        {
            return await CommandAsync("highlightRect", 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("width", width), 
                 new KeyValuePair<string, object>("height", height), 
                 new KeyValuePair<string, object>("color", color), 
                 new KeyValuePair<string, object>("outlineColor", outlineColor)
                 );
        }
    }
}
