using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain
    {
        /// <summary>
        /// Controls whether to discover available targets and notify via `targetCreated/targetInfoChanged/targetDestroyed` events.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-setDiscoverTargets"/>
        /// </summary>
        /// <param name="discover">Whether to discover available targets.</param>
        /// <returns></returns>
        public async Task<JObject> SetDiscoverTargetsAsync(bool discover)
        {
            return await CommandAsync("setDiscoverTargets", 
                 new KeyValuePair<string, object>("discover", discover)
                 );
        }
    }
}
