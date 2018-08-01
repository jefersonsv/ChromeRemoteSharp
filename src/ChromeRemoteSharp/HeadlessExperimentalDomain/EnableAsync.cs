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
        /// Enables headless events for the target.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeadlessExperimental#enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
