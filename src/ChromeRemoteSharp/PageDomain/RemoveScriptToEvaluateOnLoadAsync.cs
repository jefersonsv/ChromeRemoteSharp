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
        /// Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-removeScriptToEvaluateOnLoad"/>
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public async Task<JObject> RemoveScriptToEvaluateOnLoadAsync(string identifier)
        {
            return await CommandAsync("removeScriptToEvaluateOnLoad", 
                 new KeyValuePair<string, object>("identifier", identifier)
                 );
        }
    }
}
