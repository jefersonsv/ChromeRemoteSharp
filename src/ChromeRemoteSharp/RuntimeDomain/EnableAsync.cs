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
        /// Enables reporting of execution contexts creation by means of `executionContextCreated` event. When the reporting gets enabled the event will be sent immediately for each existing execution context.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
