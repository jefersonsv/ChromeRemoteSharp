using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.TargetDomain
{
    public partial class TargetDomain
    {
        /// <summary>
        /// Creates a new page.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Target#method-createTarget"/>
        /// </summary>
        /// <param name="url">The initial URL the page will be navigated to.</param>
        /// <param name="width">Frame width in DIP (headless chrome only).</param>
        /// <param name="height">Frame height in DIP (headless chrome only).</param>
        /// <param name="browserContextId">The browser context to create the page in.</param>
        /// <param name="enableBeginFrameControl">Whether BeginFrames for this target will be controlled via DevTools (headless chrome only, not supported on MacOS yet, false by default).</param>
        /// <returns></returns>
        public async Task<JObject> CreateTargetAsync(string url, string width = null, string height = null, string browserContextId = null, bool? enableBeginFrameControl = null)
        {
            return await CommandAsync("createTarget", 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("width", width), 
                 new KeyValuePair<string, object>("height", height), 
                 new KeyValuePair<string, object>("browserContextId", browserContextId), 
                 new KeyValuePair<string, object>("enableBeginFrameControl", enableBeginFrameControl)
                 );
        }
    }
}
