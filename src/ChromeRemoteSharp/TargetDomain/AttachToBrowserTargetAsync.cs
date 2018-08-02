using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain
    {
        /// <summary>
        /// Attaches to the browser target, only uses flat sessionId mode.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-attachToBrowserTarget"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> AttachToBrowserTargetAsync()
        {
            return await CommandAsync("attachToBrowserTarget");
        }
    }
}
