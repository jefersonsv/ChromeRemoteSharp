using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDebuggerDomain
{
    public partial class DomDebuggerDomain
    {
        /// <summary>
        /// Removes breakpoint on particular DOM event.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMDebugger#method-removeEventListenerBreakpoint"/>
        /// </summary>
        /// <param name="eventName">Event name.</param>
        /// <param name="targetName">EventTarget interface name.</param>
        /// <returns></returns>
        public async Task<JObject> RemoveEventListenerBreakpointAsync(string eventName, string targetName = null)
        {
            return await CommandAsync("removeEventListenerBreakpoint", 
                 new KeyValuePair<string, object>("eventName", eventName), 
                 new KeyValuePair<string, object>("targetName", targetName)
                 );
        }
    }
}
