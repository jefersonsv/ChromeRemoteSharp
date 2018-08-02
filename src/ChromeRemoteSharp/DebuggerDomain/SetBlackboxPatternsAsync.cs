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
        /// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in scripts with url matching one of the patterns. VM will try to leave blackboxed script by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-setBlackboxPatterns"/>
        /// </summary>
        /// <param name="patterns">Array of regexps that will be used to check script url for blackbox state.</param>
        /// <returns></returns>
        public async Task<JObject> SetBlackboxPatternsAsync(string[] patterns)
        {
            return await CommandAsync("setBlackboxPatterns", 
                 new KeyValuePair<string, object>("patterns", patterns)
                 );
        }
    }
}
