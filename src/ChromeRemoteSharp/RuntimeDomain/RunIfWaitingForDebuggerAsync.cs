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
        /// Tells inspected instance to run if it was waiting for debugger to attach.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-runIfWaitingForDebugger"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> RunIfWaitingForDebuggerAsync()
        {
            return await CommandAsync("runIfWaitingForDebugger");
        }
    }
}
