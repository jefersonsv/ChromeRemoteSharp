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
        /// Dispatches a touch event to the page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#method-dispatchTouchEvent"/>
        /// </summary>
        /// <param name="type">Type of the touch event. TouchEnd and TouchCancel must not contain any touch points, while TouchStart and TouchMove must contains at least one.</param>
        /// <param name="touchPoints">Active touch points on the touch device. One event per any changed point (compared to previous touch event in a sequence) is generated, emulating pressing/moving/releasing points one by one.</param>
        /// <param name="modifiers">Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8 (default: 0).</param>
        /// <param name="timestamp">Time at which the event occurred.</param>
        /// <returns></returns>
        public async Task<JObject> DispatchTouchEventAsync(string type, string[] touchPoints, string modifiers = null, string timestamp = null)
        {
            return await CommandAsync("dispatchTouchEvent", 
                 new KeyValuePair<string, object>("type", type), 
                 new KeyValuePair<string, object>("touchPoints", touchPoints), 
                 new KeyValuePair<string, object>("modifiers", modifiers), 
                 new KeyValuePair<string, object>("timestamp", timestamp)
                 );
        }
    }
}
