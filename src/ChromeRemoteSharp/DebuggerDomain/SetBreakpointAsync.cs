using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DebuggerDomain
{
    public partial class DebuggerDomain
    {
        /// <summary>
        /// Sets JavaScript breakpoint at a given location.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#setBreakpoint"/>
        /// </summary>
        /// <param name="location">Location to set breakpoint in.</param>
        /// <param name="condition">Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.</param>
        /// <returns></returns>
        public async Task<JObject> SetBreakpointAsync(string location,string condition)
        {
            return await CommandAsync("setBreakpoint", 
                 new KeyValuePair<string, object>("location", location), 
                 new KeyValuePair<string, object>("condition", condition)
                 );
        }
    }
}
