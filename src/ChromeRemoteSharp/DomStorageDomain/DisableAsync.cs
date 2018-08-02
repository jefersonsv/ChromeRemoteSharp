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
        /// Disables storage tracking, prevents storage events from being sent to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMStorage#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
