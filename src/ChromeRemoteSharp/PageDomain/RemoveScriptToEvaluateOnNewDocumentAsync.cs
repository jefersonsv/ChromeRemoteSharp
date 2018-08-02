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
        /// Removes given script from the list.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-removeScriptToEvaluateOnNewDocument"/>
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public async Task<JObject> RemoveScriptToEvaluateOnNewDocumentAsync(string identifier)
        {
            return await CommandAsync("removeScriptToEvaluateOnNewDocument", 
                 new KeyValuePair<string, object>("identifier", identifier)
                 );
        }
    }
}
