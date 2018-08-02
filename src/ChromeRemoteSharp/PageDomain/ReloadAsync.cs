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
        /// Reloads given page optionally ignoring the cache.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-reload"/>
        /// </summary>
        /// <param name="ignoreCache">If true, browser cache is ignored (as if the user pressed Shift+refresh).</param>
        /// <param name="scriptToEvaluateOnLoad">If set, the script will be injected into all frames of the inspected page after reload. Argument will be ignored if reloading dataURL origin.</param>
        /// <returns></returns>
        public async Task<JObject> ReloadAsync(bool? ignoreCache = null, string scriptToEvaluateOnLoad = null)
        {
            return await CommandAsync("reload", 
                 new KeyValuePair<string, object>("ignoreCache", ignoreCache), 
                 new KeyValuePair<string, object>("scriptToEvaluateOnLoad", scriptToEvaluateOnLoad)
                 );
        }
    }
}
