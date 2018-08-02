using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomStorageDomain
{
    public partial class DomStorageDomain
    {
        /// <summary>
        /// Enables storage tracking, storage events will now be delivered to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMStorage#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
