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
        /// Returns possible locations for breakpoint. scriptId in start and end range locations should be the same.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#getPossibleBreakpoints"/>
        /// </summary>
        /// <param name="start">Start of range to search possible breakpoint locations in.</param>
        /// <param name="end">End of range to search possible breakpoint locations in (excluding). When not specified, end of scripts is used as end of range.</param>
        /// <param name="restrictToFunction">Only consider locations which are in the same (non-nested) function as start.</param>
        /// <returns></returns>
        public async Task<JObject> GetPossibleBreakpointsAsync(string start,string end,bool? restrictToFunction)
        {
            return await CommandAsync("getPossibleBreakpoints", 
                 new KeyValuePair<string, object>("start", start), 
                 new KeyValuePair<string, object>("end", end), 
                 new KeyValuePair<string, object>("restrictToFunction", restrictToFunction)
                 );
        }
    }
}
