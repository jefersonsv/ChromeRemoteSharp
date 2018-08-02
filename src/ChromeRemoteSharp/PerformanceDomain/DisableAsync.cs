using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PerformanceDomain
{
    public partial class PerformanceDomain
    {
        /// <summary>
        /// Disable collecting and reporting metrics.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Performance#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
