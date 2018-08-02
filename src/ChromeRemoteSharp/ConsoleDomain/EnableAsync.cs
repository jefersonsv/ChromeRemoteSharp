using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ConsoleDomain
{
    public partial class ConsoleDomain
    {
        /// <summary>
        /// Enables console domain, sends the messages collected so far to the client by means of the `messageAdded` notification.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Console#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
