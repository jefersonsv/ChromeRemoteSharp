using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Stops sending each frame in the `screencastFrame`.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#stopScreencast"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> StopScreencastAsync()
        {
            return await CommandAsync("stopScreencast");
        }
    }
}
