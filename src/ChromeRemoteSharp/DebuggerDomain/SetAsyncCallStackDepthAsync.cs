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
        /// Enables or disables async call stacks tracking.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-setAsyncCallStackDepth"/>
        /// </summary>
        /// <param name="maxDepth">Maximum depth of async call stacks. Setting to `0` will effectively disable collecting async call stacks (default).</param>
        /// <returns></returns>
        public async Task<JObject> SetAsyncCallStackDepthAsync(string maxDepth)
        {
            return await CommandAsync("setAsyncCallStackDepth", 
                 new KeyValuePair<string, object>("maxDepth", maxDepth)
                 );
        }
    }
}
