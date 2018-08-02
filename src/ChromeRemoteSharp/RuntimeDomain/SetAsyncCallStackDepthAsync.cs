using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain
    {
        /// <summary>
        /// Enables or disables async call stacks tracking.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-setAsyncCallStackDepth"/>
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
