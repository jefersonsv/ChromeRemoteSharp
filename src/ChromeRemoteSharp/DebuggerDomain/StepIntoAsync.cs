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
        /// Steps into the function call.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-stepInto"/>
        /// </summary>
        /// <param name="breakOnAsyncCall">Debugger will issue additional Debugger.paused notification if any async task is scheduled before next pause.</param>
        /// <returns></returns>
        public async Task<JObject> StepIntoAsync(bool? breakOnAsyncCall = null)
        {
            return await CommandAsync("stepInto", 
                 new KeyValuePair<string, object>("breakOnAsyncCall", breakOnAsyncCall)
                 );
        }
    }
}
