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
        /// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#method-synthesizeTapGesture"/>
        /// </summary>
        /// <param name="x">X coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name="y">Y coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name="duration">Duration between touchdown and touchup events in ms (default: 50).</param>
        /// <param name="tapCount">Number of times to perform the tap (e.g. 2 for double tap, default: 1).</param>
        /// <param name="gestureSourceType">Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).</param>
        /// <returns></returns>
        public async Task<JObject> SynthesizeTapGestureAsync(int x, int y, string duration = null, string tapCount = null, string gestureSourceType = null)
        {
            return await CommandAsync("synthesizeTapGesture", 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("duration", duration), 
                 new KeyValuePair<string, object>("tapCount", tapCount), 
                 new KeyValuePair<string, object>("gestureSourceType", gestureSourceType)
                 );
        }
    }
}
