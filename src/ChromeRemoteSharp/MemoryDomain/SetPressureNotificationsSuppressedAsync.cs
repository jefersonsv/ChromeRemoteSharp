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
        /// Enable/disable suppressing memory pressure notifications in all processes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#method-setPressureNotificationsSuppressed"/>
        /// </summary>
        /// <param name="suppressed">If true, memory pressure notifications will be suppressed.</param>
        /// <returns></returns>
        public async Task<JObject> SetPressureNotificationsSuppressedAsync(bool suppressed)
        {
            return await CommandAsync("setPressureNotificationsSuppressed", 
                 new KeyValuePair<string, object>("suppressed", suppressed)
                 );
        }
    }
}
