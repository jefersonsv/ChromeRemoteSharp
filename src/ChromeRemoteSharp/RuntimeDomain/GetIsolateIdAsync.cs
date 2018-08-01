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
        /// Returns the isolate id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#getIsolateId"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetIsolateIdAsync()
        {
            return await CommandAsync("getIsolateId");
        }
    }
}
