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
        /// Force the page stop all navigations and pending resource fetches.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-stopLoading"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopLoadingAsync()
        {
            return await CommandAsync("stopLoading");
        }
    }
}
