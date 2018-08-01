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
        /// Removes JavaScript breakpoint.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#removeBreakpoint"/>
        /// </summary>
        /// <param name="breakpointId"></param>
        /// <returns></returns>
        public async Task<JObject> RemoveBreakpointAsync(string breakpointId)
        {
            return await CommandAsync("removeBreakpoint", 
                 new KeyValuePair<string, object>("breakpointId", breakpointId)
                 );
        }
    }
}
