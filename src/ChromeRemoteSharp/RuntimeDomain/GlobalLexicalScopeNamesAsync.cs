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
        /// Returns all let, const and class variables from global scope.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-globalLexicalScopeNames"/>
        /// </summary>
        /// <param name="executionContextId">Specifies in which execution context to lookup global scope variables.</param>
        /// <returns></returns>
        public async Task<JObject> GlobalLexicalScopeNamesAsync(string executionContextId = null)
        {
            return await CommandAsync("globalLexicalScopeNames", 
                 new KeyValuePair<string, object>("executionContextId", executionContextId)
                 );
        }
    }
}
