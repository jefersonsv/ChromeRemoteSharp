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
        /// Emulates touch event from the mouse event parameters.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#emulateTouchFromMouseEvent"/>
        /// </summary>
        /// <param name="type">Type of the mouse event.</param>
        /// <param name="x">X coordinate of the mouse pointer in DIP.</param>
        /// <param name="y">Y coordinate of the mouse pointer in DIP.</param>
        /// <param name="button">Mouse button.</param>
        /// <param name="timestamp">Time at which the event occurred (default: current time).</param>
        /// <param name="deltaX">X delta in DIP for mouse wheel event (default: 0).</param>
        /// <param name="deltaY">Y delta in DIP for mouse wheel event (default: 0).</param>
        /// <param name="modifiers">Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).</param>
        /// <param name="clickCount">Number of times the mouse button was clicked (default: 0).</param>
        /// <returns></returns>
        public async Task<JObject> EmulateTouchFromMouseEventAsync(string type,string x,string y,string button,string timestamp,int? deltaX,int? deltaY,string modifiers,string clickCount)
        {
            return await CommandAsync("emulateTouchFromMouseEvent", 
                 new KeyValuePair<string, object>("type", type), 
                 new KeyValuePair<string, object>("x", x), 
                 new KeyValuePair<string, object>("y", y), 
                 new KeyValuePair<string, object>("button", button), 
                 new KeyValuePair<string, object>("timestamp", timestamp), 
                 new KeyValuePair<string, object>("deltaX", deltaX), 
                 new KeyValuePair<string, object>("deltaY", deltaY), 
                 new KeyValuePair<string, object>("modifiers", modifiers), 
                 new KeyValuePair<string, object>("clickCount", clickCount)
                 );
        }
    }
}
