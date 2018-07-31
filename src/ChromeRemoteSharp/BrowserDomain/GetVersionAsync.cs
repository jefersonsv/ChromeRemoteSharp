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
        /// <seealso cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-getVersion"/>
        /// </summary>
        /// <returns></returns>
        public async Task<JObject> GetVersionAsync()
        {
            return await CommandAsync("getVersion");
        }
    }
}
