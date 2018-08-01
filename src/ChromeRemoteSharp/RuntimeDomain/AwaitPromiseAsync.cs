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
        /// Add handler to promise with given promise object id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#awaitPromise"/>
        /// </summary>
        /// <param name="promiseObjectId">Identifier of the promise.</param>
        /// <param name="returnByValue">Whether the result is expected to be a JSON object that should be sent by value.</param>
        /// <param name="generatePreview">Whether preview should be generated for the result.</param>
        /// <returns></returns>
        public async Task<JObject> AwaitPromiseAsync(string promiseObjectId,bool? returnByValue,bool? generatePreview)
        {
            return await CommandAsync("awaitPromise", 
                 new KeyValuePair<string, object>("promiseObjectId", promiseObjectId), 
                 new KeyValuePair<string, object>("returnByValue", returnByValue), 
                 new KeyValuePair<string, object>("generatePreview", generatePreview)
                 );
        }
    }
}
