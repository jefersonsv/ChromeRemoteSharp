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
        /// Get position and size of the browser window.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-getWindowBounds"/>
        /// </summary>
        /// <param name="windowId">Browser window id.</param>
        /// <returns></returns>
        public async Task<JObject> GetWindowBoundsAsync(string windowId)
        {
            return await CommandAsync("getWindowBounds", 
                 new KeyValuePair<string, object>("windowId", windowId)
                 );
        }
    }
}
