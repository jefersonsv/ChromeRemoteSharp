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
        /// Disables inspector domain notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Inspector#disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
