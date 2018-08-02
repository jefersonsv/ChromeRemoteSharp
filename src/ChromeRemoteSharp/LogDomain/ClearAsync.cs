using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.LogDomain
{
    public partial class LogDomain
    {
        /// <summary>
        /// Clears the log.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Log#method-clear"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> ClearAsync()
        {
            return await CommandAsync("clear");
        }
    }
}
