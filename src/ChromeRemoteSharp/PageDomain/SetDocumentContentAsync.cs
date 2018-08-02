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
        /// Sets given markup as the document's HTML.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-setDocumentContent"/>
        /// </summary>
        /// <param name="frameId">Frame id to set HTML for.</param>
        /// <param name="html">HTML content to set.</param>
        /// <returns></returns>
        public async Task<JObject> SetDocumentContentAsync(string frameId, string html)
        {
            return await CommandAsync("setDocumentContent", 
                 new KeyValuePair<string, object>("frameId", frameId), 
                 new KeyValuePair<string, object>("html", html)
                 );
        }
    }
}
