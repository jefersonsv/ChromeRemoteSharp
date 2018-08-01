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
        /// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#addScriptToEvaluateOnLoad"/>
        /// </summary>
        /// <param name="scriptSource"></param>
        /// <returns></returns>
        public async Task<JObject> AddScriptToEvaluateOnLoadAsync(string scriptSource)
        {
            return await CommandAsync("addScriptToEvaluateOnLoad", 
                 new KeyValuePair<string, object>("scriptSource", scriptSource)
                 );
        }
    }
}
