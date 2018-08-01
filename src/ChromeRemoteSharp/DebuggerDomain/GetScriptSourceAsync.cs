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
        /// Returns source for the script with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#getScriptSource"/>
        /// </summary>
        /// <param name="scriptId">Id of the script to get source for.</param>
        /// <returns></returns>
        public async Task<JObject> GetScriptSourceAsync(string scriptId)
        {
            return await CommandAsync("getScriptSource", 
                 new KeyValuePair<string, object>("scriptId", scriptId)
                 );
        }
    }
}
