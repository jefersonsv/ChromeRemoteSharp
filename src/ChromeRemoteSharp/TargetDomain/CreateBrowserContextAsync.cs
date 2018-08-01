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
        /// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than one.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#createBrowserContext"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CreateBrowserContextAsync()
        {
            return await CommandAsync("createBrowserContext");
        }
    }
}
