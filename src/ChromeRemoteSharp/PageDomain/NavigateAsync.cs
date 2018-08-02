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
        /// Navigates current page to the given URL.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-navigate"/>
        /// </summary>
        /// <param name="url">URL to navigate the page to.</param>
        /// <param name="referrer">Referrer URL.</param>
        /// <param name="transitionType">Intended transition type.</param>
        /// <param name="frameId">Frame id to navigate, if not specified navigates the top frame.</param>
        /// <returns></returns>
        public async Task<JObject> NavigateAsync(string url, string referrer = null, string transitionType = null, string frameId = null)
        {
            return await CommandAsync("navigate", 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("referrer", referrer), 
                 new KeyValuePair<string, object>("transitionType", transitionType), 
                 new KeyValuePair<string, object>("frameId", frameId)
                 );
        }
    }
}
