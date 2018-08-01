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
        /// Sets JavaScript breakpoint before each call to the given function. If another function was created from the same source as a given one, calling it will also trigger the breakpoint.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#setBreakpointOnFunctionCall"/>
        /// </summary>
        /// <param name="objectId">Function object id.</param>
        /// <param name="condition">Expression to use as a breakpoint condition. When specified, debugger will stop on the breakpoint if this expression evaluates to true.</param>
        /// <returns></returns>
        public async Task<JObject> SetBreakpointOnFunctionCallAsync(string objectId,string condition)
        {
            return await CommandAsync("setBreakpointOnFunctionCall", 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("condition", condition)
                 );
        }
    }
}
