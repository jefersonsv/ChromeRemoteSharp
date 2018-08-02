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
        /// Terminate current or next JavaScript execution. Will cancel the termination when the outer-most script execution ends.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-terminateExecution"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> TerminateExecutionAsync()
        {
            return await CommandAsync("terminateExecution");
        }
    }
}
