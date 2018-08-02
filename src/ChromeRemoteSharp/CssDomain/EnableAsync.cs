using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain
    {
        /// <summary>
        /// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been enabled until the result of this command is received.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CSS#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
