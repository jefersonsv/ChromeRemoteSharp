using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.EmulationDomain
{
    public partial class EmulationDomain
    {
        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Emulation#setGeolocationOverride"/>
        /// </summary>
        /// <param name="latitude">Mock latitude</param>
        /// <param name="longitude">Mock longitude</param>
        /// <param name="accuracy">Mock accuracy</param>
        /// <returns></returns>
        public async Task<JObject> SetGeolocationOverrideAsync(int? latitude,int? longitude,int? accuracy)
        {
            return await CommandAsync("setGeolocationOverride", 
                 new KeyValuePair<string, object>("latitude", latitude), 
                 new KeyValuePair<string, object>("longitude", longitude), 
                 new KeyValuePair<string, object>("accuracy", accuracy)
                 );
        }
    }
}
