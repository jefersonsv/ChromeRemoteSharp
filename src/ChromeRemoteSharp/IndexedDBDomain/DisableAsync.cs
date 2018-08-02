using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.IndexedDBDomain
{
    public partial class IndexedDBDomain
    {
        /// <summary>
        /// Disables events from backend.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
