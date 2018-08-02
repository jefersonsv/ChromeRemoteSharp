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
        /// Steps out of the function call.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-stepOut"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StepOutAsync()
        {
            return await CommandAsync("stepOut");
        }
    }
}
