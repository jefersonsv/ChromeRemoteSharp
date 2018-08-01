using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.InputDomain
{
    public partial class InputDomain
    {
        /// <summary>
        /// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#synthesizePinchGesture"/>
        /// </summary>
        /// <param name="x">X coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name="y">Y coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name="scaleFactor">Relative scale factor after zooming (>1.0 zooms in, <1.0 zooms out).</param>
        /// <param name="relativeSpeed">Relative pointer speed in pixels per second (default: 800).</param>
        /// <param name="gestureSourceType">Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).</param>
        /// <returns></returns>
        public async Task<JObject> SynthesizePinchGestureAsync(int x,int y,int scaleFactor,string relativeSpeed,string gestureSourceType)
        {
            return await CommandAsync("synthesizePinchGesture", 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("scaleFactor", scaleFactor), 
                 new KeyValuePair<string, object>("relativeSpeed", relativeSpeed), 
                 new KeyValuePair<string, object>("gestureSourceType", gestureSourceType)
                 );
        }
    }
}
