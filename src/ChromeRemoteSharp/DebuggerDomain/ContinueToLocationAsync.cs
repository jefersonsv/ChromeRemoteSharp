using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DebuggerDomain
{
    public partial class DebuggerDomain
    {
        /// <summary>
        /// Continues execution until specific location is reached.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-continueToLocation"/>
        /// </summary>
        /// <param name="location">Location to continue to.</param>
        /// <param name="targetCallFrames"></param>
        /// <returns></returns>
        public async Task<JObject> ContinueToLocationAsync(string location, string targetCallFrames = null)
        {
            return await CommandAsync("continueToLocation", 
                 new KeyValuePair<string, object>("location", location), 
                 new KeyValuePair<string, object>("targetCallFrames", targetCallFrames)
                 );
        }
    }
}
