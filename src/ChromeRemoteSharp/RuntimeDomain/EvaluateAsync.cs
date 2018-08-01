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
        /// Evaluates expression on global object.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#evaluate"/>
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="objectGroup">Symbolic group name that can be used to release multiple objects.</param>
        /// <param name="includeCommandLineAPI">Determines whether Command Line API should be available during the evaluation.</param>
        /// <param name="silent">In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides `setPauseOnException` state.</param>
        /// <param name="contextId">Specifies in which execution context to perform evaluation. If the parameter is omitted the evaluation will be performed in the context of the inspected page.</param>
        /// <param name="returnByValue">Whether the result is expected to be a JSON object that should be sent by value.</param>
        /// <param name="generatePreview">Whether preview should be generated for the result.</param>
        /// <param name="userGesture">Whether execution should be treated as initiated by user in the UI.</param>
        /// <param name="awaitPromise">Whether execution should `await` for resulting value and return once awaited promise is resolved.</param>
        /// <param name="throwOnSideEffect">Whether to throw an exception if side effect cannot be ruled out during evaluation.</param>
        /// <param name="timeout">Terminate execution after timing out (number of milliseconds).</param>
        /// <returns></returns>
        public async Task<JObject> EvaluateAsync(string expression,string objectGroup,bool? includeCommandLineAPI,bool? silent,string contextId,bool? returnByValue,bool? generatePreview,bool? userGesture,bool? awaitPromise,bool? throwOnSideEffect,string timeout)
        {
            return await CommandAsync("evaluate", 
                 new KeyValuePair<string, object>("expression", expression), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup), 
                 new KeyValuePair<string, object>("includeCommandLineAPI", includeCommandLineAPI), 
                 new KeyValuePair<string, object>("silent", silent), 
                 new KeyValuePair<string, object>("contextId", contextId), 
                 new KeyValuePair<string, object>("returnByValue", returnByValue), 
                 new KeyValuePair<string, object>("generatePreview", generatePreview), 
                 new KeyValuePair<string, object>("userGesture", userGesture), 
                 new KeyValuePair<string, object>("awaitPromise", awaitPromise), 
                 new KeyValuePair<string, object>("throwOnSideEffect", throwOnSideEffect), 
                 new KeyValuePair<string, object>("timeout", timeout)
                 );
        }
    }
}
