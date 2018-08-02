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
        /// Evaluates given script in every frame upon creation (before loading frame's scripts).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-addScriptToEvaluateOnNewDocument"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public async Task<JObject> AddScriptToEvaluateOnNewDocumentAsync(string source)
        {
            return await CommandAsync("addScriptToEvaluateOnNewDocument", 
                 new KeyValuePair<string, object>("source", source)
                 );
        }
    }
}
