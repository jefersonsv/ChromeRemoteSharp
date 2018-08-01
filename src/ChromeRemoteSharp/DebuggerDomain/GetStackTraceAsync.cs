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
        /// Returns stack trace with given `stackTraceId`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#getStackTrace"/>
        /// </summary>
        /// <param name="stackTraceId"></param>
        /// <returns></returns>
        public async Task<JObject> GetStackTraceAsync(string stackTraceId)
        {
            return await CommandAsync("getStackTrace", 
                 new KeyValuePair<string, object>("stackTraceId", stackTraceId)
                 );
        }
    }
}
