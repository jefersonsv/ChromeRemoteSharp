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
        /// Simulate a memory pressure notification in all processes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Memory#simulatePressureNotification"/>
        /// </summary>
        /// <param name="level">Memory pressure level of the notification.</param>
        /// <returns></returns>
        public async Task<JObject> SimulatePressureNotificationAsync(string level)
        {
            return await CommandAsync("simulatePressureNotification", 
                 new KeyValuePair<string, object>("level", level)
                 );
        }
    }
}
