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
        /// Returns the JavaScript heap usage. It is the total usage of the corresponding isolate not scoped to a particular Runtime.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#method-getHeapUsage"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetHeapUsageAsync()
        {
            return await CommandAsync("getHeapUsage");
        }
    }
}
