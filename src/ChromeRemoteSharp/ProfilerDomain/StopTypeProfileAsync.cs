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
        /// Disable type profile. Disabling releases type profile data collected so far.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#method-stopTypeProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopTypeProfileAsync()
        {
            return await CommandAsync("stopTypeProfile");
        }
    }
}
