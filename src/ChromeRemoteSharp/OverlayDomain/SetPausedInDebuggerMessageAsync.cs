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
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Overlay#setPausedInDebuggerMessage"/>
        /// </summary>
        /// <param name="message">The message to display, also triggers resume and step over controls.</param>
        /// <returns></returns>
        public async Task<JObject> SetPausedInDebuggerMessageAsync(string message)
        {
            return await CommandAsync("setPausedInDebuggerMessage", 
                 new KeyValuePair<string, object>("message", message)
                 );
        }
    }
}
