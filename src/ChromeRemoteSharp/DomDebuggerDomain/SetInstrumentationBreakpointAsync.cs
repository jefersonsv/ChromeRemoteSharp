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
        /// Sets breakpoint on particular native event.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMDebugger#method-setInstrumentationBreakpoint"/>
        /// </summary>
        /// <param name="eventName">Instrumentation name to stop on.</param>
        /// <returns></returns>
        public async Task<JObject> SetInstrumentationBreakpointAsync(string eventName)
        {
            return await CommandAsync("setInstrumentationBreakpoint", 
                 new KeyValuePair<string, object>("eventName", eventName)
                 );
        }
    }
}
