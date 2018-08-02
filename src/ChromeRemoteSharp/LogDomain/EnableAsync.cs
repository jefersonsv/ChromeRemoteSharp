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
        /// Enables log domain, sends the entries collected so far to the client by means of the `entryAdded` notification.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Log#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
