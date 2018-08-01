using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ApplicationCacheDomain
{
    public partial class ApplicationCacheDomain
    {
        /// <summary>
        /// Enables application cache domain notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ApplicationCache#enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
