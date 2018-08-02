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
        /// Stop trace events collection.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Tracing#method-end"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EndAsync()
        {
            return await CommandAsync("end");
        }
    }
}
