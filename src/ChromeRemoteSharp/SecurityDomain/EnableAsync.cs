using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.SecurityDomain
{
    public partial class SecurityDomain
    {
        /// <summary>
        /// Enables tracking security state changes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Security#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
