using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DatabaseDomain
{
    public partial class DatabaseDomain
    {
        /// <summary>
        /// Disables database tracking, prevents database events from being sent to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Database#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
