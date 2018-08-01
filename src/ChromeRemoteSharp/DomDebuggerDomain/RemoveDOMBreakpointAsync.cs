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
        /// Removes DOM breakpoint that was set using `setDOMBreakpoint`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomDebugger#removeDOMBreakpoint"/>
        /// </summary>
        /// <param name="nodeId">Identifier of the node to remove breakpoint from.</param>
        /// <param name="type">Type of the breakpoint to remove.</param>
        /// <returns></returns>
        public async Task<JObject> RemoveDOMBreakpointAsync(string nodeId,string type)
        {
            return await CommandAsync("removeDOMBreakpoint", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("type", type)
                 );
        }
    }
}
