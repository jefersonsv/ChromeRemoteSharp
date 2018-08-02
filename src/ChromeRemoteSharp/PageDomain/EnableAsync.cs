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
        /// Enables page domain notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
