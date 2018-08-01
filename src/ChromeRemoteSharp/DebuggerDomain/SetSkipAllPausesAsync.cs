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
        /// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#setSkipAllPauses"/>
        /// </summary>
        /// <param name="skip">New value for skip pauses state.</param>
        /// <returns></returns>
        public async Task<JObject> SetSkipAllPausesAsync(bool skip)
        {
            return await CommandAsync("setSkipAllPauses", 
                 new KeyValuePair<string, object>("skip", skip)
                 );
        }
    }
}
