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
        /// Evaluates expression on a given call frame.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#evaluateOnCallFrame"/>
        /// </summary>
        /// <param name="callFrameId">Call frame identifier to evaluate on.</param>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="objectGroup">String object group name to put result into (allows rapid releasing resulting object handles using `releaseObjectGroup`).</param>
        /// <param name="includeCommandLineAPI">Specifies whether command line API should be available to the evaluated expression, defaults to false.</param>
        /// <param name="silent">In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides `setPauseOnException` state.</param>
        /// <param name="returnByValue">Whether the result is expected to be a JSON object that should be sent by value.</param>
        /// <param name="generatePreview">Whether preview should be generated for the result.</param>
        /// <param name="throwOnSideEffect">Whether to throw an exception if side effect cannot be ruled out during evaluation.</param>
        /// <param name="timeout">Terminate execution after timing out (number of milliseconds).</param>
        /// <returns></returns>
        public async Task<JObject> EvaluateOnCallFrameAsync(string callFrameId,string expression,string objectGroup,bool? includeCommandLineAPI,bool? silent,bool? returnByValue,bool? generatePreview,bool? throwOnSideEffect,string timeout)
        {
            return await CommandAsync("evaluateOnCallFrame", 
                 new KeyValuePair<string, object>("callFrameId", callFrameId), 
                 new KeyValuePair<string, object>("expression", expression), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup), 
                 new KeyValuePair<string, object>("includeCommandLineAPI", includeCommandLineAPI), 
                 new KeyValuePair<string, object>("silent", silent), 
                 new KeyValuePair<string, object>("returnByValue", returnByValue), 
                 new KeyValuePair<string, object>("generatePreview", generatePreview), 
                 new KeyValuePair<string, object>("throwOnSideEffect", throwOnSideEffect), 
                 new KeyValuePair<string, object>("timeout", timeout)
                 );
        }
    }
}
