using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.BrowserDomain
{
    public partial class BrowserDomain
    {
        /// <summary>
        /// Close browser gracefully.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-close"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> CloseAsync()
        {
            return await CommandAsync("close");
        }
    }
}
