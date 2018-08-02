using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.AnimationDomain
{
    public partial class AnimationDomain
    {
        /// <summary>
        /// Enables animation domain notifications.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
