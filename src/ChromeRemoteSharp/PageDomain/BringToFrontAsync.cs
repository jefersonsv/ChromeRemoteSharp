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
        /// Brings page to front (activates tab).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#bringToFront"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> BringToFrontAsync()
        {
            return await CommandAsync("bringToFront");
        }
    }
}
