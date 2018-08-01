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
        /// Compiles expression.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#compileScript"/>
        /// </summary>
        /// <param name="expression">Expression to compile.</param>
        /// <param name="sourceURL">Source url to be set for the script.</param>
        /// <param name="persistScript">Specifies whether the compiled script should be persisted.</param>
        /// <param name="executionContextId">Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.</param>
        /// <returns></returns>
        public async Task<JObject> CompileScriptAsync(string expression,string sourceURL,bool persistScript,string executionContextId)
        {
            return await CommandAsync("compileScript", 
                 new KeyValuePair<string, object>("expression", expression), 
                 new KeyValuePair<string, object>("sourceURL", sourceURL), 
                 new KeyValuePair<string, object>("persistScript", persistScript), 
                 new KeyValuePair<string, object>("executionContextId", executionContextId)
                 );
        }
    }
}
