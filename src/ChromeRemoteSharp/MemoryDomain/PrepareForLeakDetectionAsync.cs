using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.MemoryDomain
{
    public partial class MemoryDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#prepareForLeakDetection"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> PrepareForLeakDetectionAsync()
        {
            return await CommandAsync("prepareForLeakDetection");
        }
    }
}
