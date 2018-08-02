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
        /// Retrieves a list of available targets.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-getTargets"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetTargetsAsync()
        {
            return await CommandAsync("getTargets");
        }
    }
}
