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
        /// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-callFunctionOn"/>
        /// </summary>
        /// <param name="functionDeclaration">Declaration of the function to call.</param>
        /// <param name="objectId">Identifier of the object to call function on. Either objectId or executionContextId should be specified.</param>
        /// <param name="arguments">Call arguments. All call arguments must belong to the same JavaScript world as the target object.</param>
        /// <param name="silent">In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides `setPauseOnException` state.</param>
        /// <param name="returnByValue">Whether the result is expected to be a JSON object which should be sent by value.</param>
        /// <param name="generatePreview">Whether preview should be generated for the result.</param>
        /// <param name="userGesture">Whether execution should be treated as initiated by user in the UI.</param>
        /// <param name="awaitPromise">Whether execution should `await` for resulting value and return once awaited promise is resolved.</param>
        /// <param name="executionContextId">Specifies execution context which global object will be used to call function on. Either executionContextId or objectId should be specified.</param>
        /// <param name="objectGroup">Symbolic group name that can be used to release multiple objects. If objectGroup is not specified and objectId is, objectGroup will be inherited from object.</param>
        /// <returns></returns>
        public async Task<JObject> CallFunctionOnAsync(string functionDeclaration, string objectId = null, string[] arguments = null, bool? silent = null, bool? returnByValue = null, bool? generatePreview = null, bool? userGesture = null, bool? awaitPromise = null, string executionContextId = null, string objectGroup = null)
        {
            return await CommandAsync("callFunctionOn", 
                 new KeyValuePair<string, object>("functionDeclaration", functionDeclaration), 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("arguments", arguments), 
                 new KeyValuePair<string, object>("silent", silent), 
                 new KeyValuePair<string, object>("returnByValue", returnByValue), 
                 new KeyValuePair<string, object>("generatePreview", generatePreview), 
                 new KeyValuePair<string, object>("userGesture", userGesture), 
                 new KeyValuePair<string, object>("awaitPromise", awaitPromise), 
                 new KeyValuePair<string, object>("executionContextId", executionContextId), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup)
                 );
        }
    }
}
