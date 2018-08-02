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
        /// Returns navigation history for the current page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-getNavigationHistory"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetNavigationHistoryAsync()
        {
            return await CommandAsync("getNavigationHistory");
        }
    }
}
