using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.InputDomain
{
    public partial class InputDomain
    {
        /// <summary>
        /// Ignores input events (useful while auditing page).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input#setIgnoreInputEvents"/>
        /// </summary>
        /// <param name="ignore">Ignores input events processing when set to true.</param>
        /// <returns></returns>
        public async Task<JObject> SetIgnoreInputEventsAsync(bool ignore)
        {
            return await CommandAsync("setIgnoreInputEvents", 
                 new KeyValuePair<string, object>("ignore", ignore)
                 );
        }
    }
}
