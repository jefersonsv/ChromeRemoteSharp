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
        /// Enables target discovery for the specified locations, when `setDiscoverTargets` was set to `true`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-setRemoteLocations"/>
        /// </summary>
        /// <param name="locations">List of remote locations.</param>
        /// <returns></returns>
        public async Task<JObject> SetRemoteLocationsAsync(string[] locations)
        {
            return await CommandAsync("setRemoteLocations", 
                 new KeyValuePair<string, object>("locations", locations)
                 );
        }
    }
}
