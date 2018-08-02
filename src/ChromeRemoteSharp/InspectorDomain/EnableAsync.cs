using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.InspectorDomain
{
    public partial class InspectorDomain
    {
        /// <summary>
        /// Enables inspector domain notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Inspector#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
