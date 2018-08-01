using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TracingDomain
{
    public partial class TracingDomain
    {
        /// <summary>
        /// Request a global memory dump.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tracing#requestMemoryDump"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> RequestMemoryDumpAsync()
        {
            return await CommandAsync("requestMemoryDump");
        }
    }
}
