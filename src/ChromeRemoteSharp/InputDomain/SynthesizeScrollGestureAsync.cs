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
        /// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#synthesizeScrollGesture"/>
        /// </summary>
        /// <param name="x">X coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name="y">Y coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name="xDistance">The distance to scroll along the X axis (positive to scroll left).</param>
        /// <param name="yDistance">The distance to scroll along the Y axis (positive to scroll up).</param>
        /// <param name="xOverscroll">The number of additional pixels to scroll back along the X axis, in addition to the given distance.</param>
        /// <param name="yOverscroll">The number of additional pixels to scroll back along the Y axis, in addition to the given distance.</param>
        /// <param name="preventFling">Prevent fling (default: true).</param>
        /// <param name="speed">Swipe speed in pixels per second (default: 800).</param>
        /// <param name="gestureSourceType">Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).</param>
        /// <param name="repeatCount">The number of times to repeat the gesture (default: 0).</param>
        /// <param name="repeatDelayMs">The number of milliseconds delay between each repeat. (default: 250).</param>
        /// <param name="interactionMarkerName">The name of the interaction markers to generate, if not empty (default: "").</param>
        /// <returns></returns>
        public async Task<JObject> SynthesizeScrollGestureAsync(int x,int y,int? xDistance,int? yDistance,int? xOverscroll,int? yOverscroll,bool? preventFling,string speed,string gestureSourceType,string repeatCount,string repeatDelayMs,string interactionMarkerName)
        {
            return await CommandAsync("synthesizeScrollGesture", 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("xDistance", xDistance), 
                 new KeyValuePair<string, object>("yDistance", yDistance), 
                 new KeyValuePair<string, object>("xOverscroll", xOverscroll), 
                 new KeyValuePair<string, object>("yOverscroll", yOverscroll), 
                 new KeyValuePair<string, object>("preventFling", preventFling), 
                 new KeyValuePair<string, object>("speed", speed), 
                 new KeyValuePair<string, object>("gestureSourceType", gestureSourceType), 
                 new KeyValuePair<string, object>("repeatCount", repeatCount), 
                 new KeyValuePair<string, object>("repeatDelayMs", repeatDelayMs), 
                 new KeyValuePair<string, object>("interactionMarkerName", interactionMarkerName)
                 );
        }
    }
}
