using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain
    {
        /// <summary>
        /// Discards collected exceptions and console API calls.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#discardConsoleEntries"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DiscardConsoleEntriesAsync()
        {
            return await CommandAsync("discardConsoleEntries");
        }
    }
}
