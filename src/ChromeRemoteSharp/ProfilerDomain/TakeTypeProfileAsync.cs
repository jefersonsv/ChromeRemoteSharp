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
        /// Collect type profile.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Profiler#method-takeTypeProfile"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> TakeTypeProfileAsync()
        {
            return await CommandAsync("takeTypeProfile");
        }
    }
}
