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
        /// Crashes renderer on the IO thread, generates minidumps.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#crash"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CrashAsync()
        {
            return await CommandAsync("crash");
        }
    }
}
