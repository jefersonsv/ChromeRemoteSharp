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
        /// Enable type profile.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#method-startTypeProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StartTypeProfileAsync()
        {
            return await CommandAsync("startTypeProfile");
        }
    }
}
