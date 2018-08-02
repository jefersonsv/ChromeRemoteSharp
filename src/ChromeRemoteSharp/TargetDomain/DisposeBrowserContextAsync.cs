using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain
    {
        /// <summary>
        /// Deletes a BrowserContext. All the belonging pages will be closed without calling their beforeunload hooks.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-disposeBrowserContext"/>
        /// </summary>
        /// <param name="browserContextId"></param>
        /// <returns></returns>
        public async Task<JObject> DisposeBrowserContextAsync(string browserContextId)
        {
            return await CommandAsync("disposeBrowserContext", 
                 new KeyValuePair<string, object>("browserContextId", browserContextId)
                 );
        }
    }
}
