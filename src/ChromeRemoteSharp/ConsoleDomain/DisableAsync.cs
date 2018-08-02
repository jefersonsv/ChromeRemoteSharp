using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ConsoleDomain
{
    public partial class ConsoleDomain
    {
        /// <summary>
        /// Disables console domain, prevents further console messages from being reported to the client.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Console#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
