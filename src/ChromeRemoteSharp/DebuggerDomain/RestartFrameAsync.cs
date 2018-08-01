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
        /// Restarts particular call frame from the beginning.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#restartFrame"/>
        /// </summary>
        /// <param name="callFrameId">Call frame identifier to evaluate on.</param>
        /// <returns></returns>
        public async Task<JObject> RestartFrameAsync(string callFrameId)
        {
            return await CommandAsync("restartFrame", 
                 new KeyValuePair<string, object>("callFrameId", callFrameId)
                 );
        }
    }
}
