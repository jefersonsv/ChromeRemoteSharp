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
        /// Stops on the next JavaScript statement.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#pause"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> PauseAsync()
        {
            return await CommandAsync("pause");
        }
    }
}
