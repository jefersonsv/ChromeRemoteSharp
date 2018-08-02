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
        /// Returns the command line switches for the browser process if, and only if --enable-automation is on the commandline.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-getBrowserCommandLine"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetBrowserCommandLineAsync()
        {
            return await CommandAsync("getBrowserCommandLine");
        }
    }
}
