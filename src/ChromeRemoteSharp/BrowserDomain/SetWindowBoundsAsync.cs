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
        /// Set position and/or size of the browser window.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Browser#method-setWindowBounds"/>
        /// </summary>
        /// <param name="windowId">Browser window id.</param>
        /// <param name="bounds">New window bounds. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined with 'left', 'top', 'width' or 'height'. Leaves unspecified fields unchanged.</param>
        /// <returns></returns>
        public async Task<JObject> SetWindowBoundsAsync(string windowId, string bounds)
        {
            return await CommandAsync("setWindowBounds", 
                 new KeyValuePair<string, object>("windowId", windowId), 
                 new KeyValuePair<string, object>("bounds", bounds)
                 );
        }
    }
}
