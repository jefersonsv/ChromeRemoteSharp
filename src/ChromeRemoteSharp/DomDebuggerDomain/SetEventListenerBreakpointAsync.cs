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
        /// Sets breakpoint on particular DOM event.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomDebugger#setEventListenerBreakpoint"/>
        /// </summary>
        /// <param name="eventName">DOM Event name to stop on (any DOM event will do).</param>
        /// <param name="targetName">EventTarget interface name to stop on. If equal to `"*"` or not provided, will stop on any EventTarget.</param>
        /// <returns></returns>
        public async Task<JObject> SetEventListenerBreakpointAsync(string eventName,string targetName)
        {
            return await CommandAsync("setEventListenerBreakpoint", 
                 new KeyValuePair<string, object>("eventName", eventName), 
                 new KeyValuePair<string, object>("targetName", targetName)
                 );
        }
    }
}
