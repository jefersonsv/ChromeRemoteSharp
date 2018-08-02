using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.LogDomain
{
    public partial class LogDomain
    {
        /// <summary>
        /// Disables log domain, prevents further log entries from being reported to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Log#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
