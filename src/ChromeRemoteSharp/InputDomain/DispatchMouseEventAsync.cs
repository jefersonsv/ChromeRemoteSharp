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
        /// Dispatches a mouse event to the page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#method-dispatchMouseEvent"/>
        /// </summary>
        /// <param name="type">Type of the mouse event.</param>
        /// <param name="x">X coordinate of the event relative to the main frame's viewport in CSS pixels.</param>
        /// <param name="y">Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.</param>
        /// <param name="modifiers">Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).</param>
        /// <param name="timestamp">Time at which the event occurred.</param>
        /// <param name="button">Mouse button (default: "none").</param>
        /// <param name="clickCount">Number of times the mouse button was clicked (default: 0).</param>
        /// <param name="deltaX">X delta in CSS pixels for mouse wheel event (default: 0).</param>
        /// <param name="deltaY">Y delta in CSS pixels for mouse wheel event (default: 0).</param>
        /// <returns></returns>
        public async Task<JObject> DispatchMouseEventAsync(string type, int x, int y, string modifiers = null, string timestamp = null, string button = null, string clickCount = null, int? deltaX = null, int? deltaY = null)
        {
            return await CommandAsync("dispatchMouseEvent", 
                 new KeyValuePair<string, object>("type", type), 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("modifiers", modifiers), 
                 new KeyValuePair<string, object>("timestamp", timestamp), 
                 new KeyValuePair<string, object>("button", button), 
                 new KeyValuePair<string, object>("clickCount", clickCount), 
                 new KeyValuePair<string, object>("deltaX", deltaX), 
                 new KeyValuePair<string, object>("deltaY", deltaY)
                 );
        }
    }
}
