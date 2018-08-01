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
        /// Enables database tracking, database events will now be delivered to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Database#enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
