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
        /// Steps over the statement.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-stepOver"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StepOverAsync()
        {
            return await CommandAsync("stepOver");
        }
    }
}
