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
        /// Get the browser window that contains the devtools target.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-getWindowForTarget"/>
        /// </summary>
        /// <param name="targetId">Devtools agent host id.</param>
        /// <returns></returns>
        public async Task<JObject> GetWindowForTargetAsync(string targetId)
        {
            return await CommandAsync("getWindowForTarget", 
                 new KeyValuePair<string, object>("targetId", targetId)
                 );
        }
    }
}
