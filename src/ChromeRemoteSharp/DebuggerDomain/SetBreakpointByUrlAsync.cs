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
        /// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this command is issued, all existing parsed scripts will have breakpoints resolved and returned in `locations` property. Further matching script parsing will result in subsequent `breakpointResolved` events issued. This logical breakpoint will survive page reloads.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-setBreakpointByUrl"/>
        /// </summary>
        /// <param name="lineNumber">Line number to set breakpoint at.</param>
        /// <param name="url">URL of the resources to set breakpoint on.</param>
        /// <param name="urlRegex">Regex pattern for the URLs of the resources to set breakpoints on. Either `url` or `urlRegex` must be specified.</param>
        /// <param name="scriptHash">Script hash of the resources to set breakpoint on.</param>
        /// <param name="columnNumber">Offset in the line to set breakpoint at.</param>
        /// <param name="condition">Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.</param>
        /// <returns></returns>
        public async Task<JObject> SetBreakpointByUrlAsync(string lineNumber, string url = null, string urlRegex = null, string scriptHash = null, string columnNumber = null, string condition = null)
        {
            return await CommandAsync("setBreakpointByUrl", 
                 new KeyValuePair<string, object>("lineNumber", lineNumber), 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("urlRegex", urlRegex), 
                 new KeyValuePair<string, object>("scriptHash", scriptHash), 
                 new KeyValuePair<string, object>("columnNumber", columnNumber), 
                 new KeyValuePair<string, object>("condition", condition)
                 );
        }
    }
}
