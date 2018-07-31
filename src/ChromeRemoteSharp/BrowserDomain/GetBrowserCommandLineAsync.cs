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
        /// <seealso cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-getBrowserCommandLine"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetBrowserCommandLineAsync()
        {
            return await CommandAsync("getBrowserCommandLine");
        }
    }
}
