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
        /// Runs script with given id in a given context.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-runScript"/>
        /// </summary>
        /// <param name="scriptId">Id of the script to run.</param>
        /// <param name="executionContextId">Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.</param>
        /// <param name="objectGroup">Symbolic group name that can be used to release multiple objects.</param>
        /// <param name="silent">In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides `setPauseOnException` state.</param>
        /// <param name="includeCommandLineAPI">Determines whether Command Line API should be available during the evaluation.</param>
        /// <param name="returnByValue">Whether the result is expected to be a JSON object which should be sent by value.</param>
        /// <param name="generatePreview">Whether preview should be generated for the result.</param>
        /// <param name="awaitPromise">Whether execution should `await` for resulting value and return once awaited promise is resolved.</param>
        /// <returns></returns>
        public async Task<JObject> RunScriptAsync(string scriptId, string executionContextId = null, string objectGroup = null, bool? silent = null, bool? includeCommandLineAPI = null, bool? returnByValue = null, bool? generatePreview = null, bool? awaitPromise = null)
        {
            return await CommandAsync("runScript", 
                 new KeyValuePair<string, object>("scriptId", scriptId), 
                 new KeyValuePair<string, object>("executionContextId", executionContextId), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup), 
                 new KeyValuePair<string, object>("silent", silent), 
                 new KeyValuePair<string, object>("includeCommandLineAPI", includeCommandLineAPI), 
                 new KeyValuePair<string, object>("returnByValue", returnByValue), 
                 new KeyValuePair<string, object>("generatePreview", generatePreview), 
                 new KeyValuePair<string, object>("awaitPromise", awaitPromise)
                 );
        }
    }
}
