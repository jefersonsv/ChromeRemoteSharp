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
        /// Disables tracking security state changes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Security#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
