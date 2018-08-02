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
        /// Clears seeded compilation cache.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-clearCompilationCache"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearCompilationCacheAsync()
        {
            return await CommandAsync("clearCompilationCache");
        }
    }
}
