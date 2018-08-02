using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.HeadlessExperimentalDomain
{
    public partial class HeadlessExperimentalDomain
    {
        /// <summary>
        /// Disables headless events for the target.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeadlessExperimental#method-disable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> DisableAsync()
        {
            return await CommandAsync("disable");
        }
    }
}
