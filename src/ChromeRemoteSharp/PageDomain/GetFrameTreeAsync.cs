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
        /// Returns present frame tree structure.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-getFrameTree"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetFrameTreeAsync()
        {
            return await CommandAsync("getFrameTree");
        }
    }
}
