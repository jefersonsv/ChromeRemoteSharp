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
        /// Tries to update the web lifecycle state of the page. It will transition the page to the given state according to: https://github.com/WICG/web-lifecycle/
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setWebLifecycleState"/>
        /// </summary>
        /// <param name="state">Target lifecycle state</param>
        /// <returns></returns>
        public async Task<JObject> SetWebLifecycleStateAsync(string state)
        {
            return await CommandAsync("setWebLifecycleState", 
                 new KeyValuePair<string, object>("state", state)
                 );
        }
    }
}
