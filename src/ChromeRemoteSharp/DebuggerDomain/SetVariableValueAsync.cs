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
        /// Changes value of variable in a callframe. Object-based scopes are not supported and must be mutated manually.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-setVariableValue"/>
        /// </summary>
        /// <param name="scopeNumber">0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch' scope types are allowed. Other scopes could be manipulated manually.</param>
        /// <param name="variableName">Variable name.</param>
        /// <param name="newValue">New variable value.</param>
        /// <param name="callFrameId">Id of callframe that holds variable.</param>
        /// <returns></returns>
        public async Task<JObject> SetVariableValueAsync(string scopeNumber, string variableName, string newValue, string callFrameId)
        {
            return await CommandAsync("setVariableValue", 
                 new KeyValuePair<string, object>("scopeNumber", scopeNumber), 
                 new KeyValuePair<string, object>("variableName", variableName), 
                 new KeyValuePair<string, object>("newValue", newValue), 
                 new KeyValuePair<string, object>("callFrameId", callFrameId)
                 );
        }
    }
}
