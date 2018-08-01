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
        /// Sets breakpoint on XMLHttpRequest.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomDebugger#setXHRBreakpoint"/>
        /// </summary>
        /// <param name="url">Resource URL substring. All XHRs having this substring in the URL will get stopped upon.</param>
        /// <returns></returns>
        public async Task<JObject> SetXHRBreakpointAsync(string url)
        {
            return await CommandAsync("setXHRBreakpoint", 
                 new KeyValuePair<string, object>("url", url)
                 );
        }
    }
}
