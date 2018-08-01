using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.SystemInfoDomain
{
    public partial class SystemInfoDomain
    {
        /// <summary>
        /// Returns information about the system.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/SystemInfo#getInfo"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetInfoAsync()
        {
            return await CommandAsync("getInfo");
        }
    }
}
