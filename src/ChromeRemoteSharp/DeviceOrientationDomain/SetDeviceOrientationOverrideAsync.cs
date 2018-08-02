using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DeviceOrientationDomain
{
    public partial class DeviceOrientationDomain
    {
        /// <summary>
        /// Overrides the Device Orientation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DeviceOrientation#method-setDeviceOrientationOverride"/>
        /// </summary>
        /// <param name="alpha">Mock alpha</param>
        /// <param name="beta">Mock beta</param>
        /// <param name="gamma">Mock gamma</param>
        /// <returns></returns>
        public async Task<JObject> SetDeviceOrientationOverrideAsync(int alpha, int beta, int gamma)
        {
            return await CommandAsync("setDeviceOrientationOverride", 
                 new KeyValuePair<string, object>("alpha", alpha), 
                 new KeyValuePair<string, object>("beta", beta), 
                 new KeyValuePair<string, object>("gamma", gamma)
                 );
        }
    }
}
