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
        /// Changes return value in top frame. Available only at return break position.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#setReturnValue"/>
        /// </summary>
        /// <param name="newValue">New return value.</param>
        /// <returns></returns>
        public async Task<JObject> SetReturnValueAsync(string newValue)
        {
            return await CommandAsync("setReturnValue", 
                 new KeyValuePair<string, object>("newValue", newValue)
                 );
        }
    }
}
