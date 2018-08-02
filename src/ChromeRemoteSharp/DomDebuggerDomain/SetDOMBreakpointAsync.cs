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
        /// Sets breakpoint on particular operation with DOM.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMDebugger#method-setDOMBreakpoint"/>
        /// </summary>
        /// <param name="nodeId">Identifier of the node to set breakpoint on.</param>
        /// <param name="type">Type of the operation to stop upon.</param>
        /// <returns></returns>
        public async Task<JObject> SetDOMBreakpointAsync(int nodeId, string type)
        {
            return await CommandAsync("setDOMBreakpoint", 
                 new KeyValuePair<string, object>("nodeId", nodeId), 
                 new KeyValuePair<string, object>("type", type)
                 );
        }
    }
}
