using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.HeapProfilerDomain
{
    public partial class HeapProfilerDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#method-getSamplingProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetSamplingProfileAsync()
        {
            return await CommandAsync("getSamplingProfile");
        }
    }
}
