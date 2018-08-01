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
        /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is `none`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#setPauseOnExceptions"/>
        /// </summary>
        /// <param name="state">Pause on exceptions mode.</param>
        /// <returns></returns>
        public async Task<JObject> SetPauseOnExceptionsAsync(string state)
        {
            return await CommandAsync("setPauseOnExceptions", 
                 new KeyValuePair<string, object>("state", state)
                 );
        }
    }
}
