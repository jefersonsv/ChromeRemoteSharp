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
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-pauseOnAsyncCall"/>
        /// </summary>
        /// <param name="parentStackTraceId">Debugger will pause when async call with given stack trace is started.</param>
        /// <returns></returns>
        public async Task<JObject> PauseOnAsyncCallAsync(string parentStackTraceId)
        {
            return await CommandAsync("pauseOnAsyncCall", 
                 new KeyValuePair<string, object>("parentStackTraceId", parentStackTraceId)
                 );
        }
    }
}
