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
        /// Does nothing.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Console#clearMessages"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearMessagesAsync()
        {
            return await CommandAsync("clearMessages");
        }
    }
}
