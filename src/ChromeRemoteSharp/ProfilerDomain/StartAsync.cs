using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ProfilerDomain
{
    public partial class ProfilerDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#start"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StartAsync()
        {
            return await CommandAsync("start");
        }
    }
}
