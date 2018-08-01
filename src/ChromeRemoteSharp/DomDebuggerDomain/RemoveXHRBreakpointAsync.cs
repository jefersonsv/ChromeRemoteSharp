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
        /// Removes breakpoint from XMLHttpRequest.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomDebugger#removeXHRBreakpoint"/>
        /// </summary>
        /// <param name="url">Resource URL substring.</param>
        /// <returns></returns>
        public async Task<JObject> RemoveXHRBreakpointAsync(string url)
        {
            return await CommandAsync("removeXHRBreakpoint", 
                 new KeyValuePair<string, object>("url", url)
                 );
        }
    }
}
