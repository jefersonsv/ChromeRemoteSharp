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
        /// Returns all browser contexts created with `Target.createBrowserContext` method.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-getBrowserContexts"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetBrowserContextsAsync()
        {
            return await CommandAsync("getBrowserContexts");
        }
    }
}
