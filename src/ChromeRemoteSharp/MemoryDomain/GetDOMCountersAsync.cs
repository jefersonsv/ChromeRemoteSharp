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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#getDOMCounters"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetDOMCountersAsync()
        {
            return await CommandAsync("getDOMCounters");
        }
    }
}
