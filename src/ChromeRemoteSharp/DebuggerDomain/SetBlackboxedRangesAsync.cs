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
        /// Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful. Positions array contains positions where blackbox state is changed. First interval isn't blackboxed. Array should be sorted.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#setBlackboxedRanges"/>
        /// </summary>
        /// <param name="scriptId">Id of the script.</param>
        /// <param name="positions"></param>
        /// <returns></returns>
        public async Task<JObject> SetBlackboxedRangesAsync(string scriptId,string[] positions)
        {
            return await CommandAsync("setBlackboxedRanges", 
                 new KeyValuePair<string, object>("scriptId", scriptId), 
                 new KeyValuePair<string, object>("positions", positions)
                 );
        }
    }
}
