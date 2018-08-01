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
        /// Resumes JavaScript execution.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#resume"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ResumeAsync()
        {
            return await CommandAsync("resume");
        }
    }
}
