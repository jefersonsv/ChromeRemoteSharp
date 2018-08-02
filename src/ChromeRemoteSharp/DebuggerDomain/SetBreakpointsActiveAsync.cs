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
        /// Activates / deactivates all breakpoints on the page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-setBreakpointsActive"/>
        /// </summary>
        /// <param name="active">New value for breakpoints active state.</param>
        /// <returns></returns>
        public async Task<JObject> SetBreakpointsActiveAsync(bool active)
        {
            return await CommandAsync("setBreakpointsActive", 
                 new KeyValuePair<string, object>("active", active)
                 );
        }
    }
}
