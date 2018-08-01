using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Tries to close page, running its beforeunload hooks, if any.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#close"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CloseAsync()
        {
            return await CommandAsync("close");
        }
    }
}
