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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#collectGarbage"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CollectGarbageAsync()
        {
            return await CommandAsync("collectGarbage");
        }
    }
}