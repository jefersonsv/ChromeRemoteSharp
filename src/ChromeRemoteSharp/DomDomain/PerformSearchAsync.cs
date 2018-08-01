using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain
    {
        /// <summary>
        /// Searches for a given string in the DOM tree. Use `getSearchResults` to access search results or `cancelSearch` to end this search session.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom#performSearch"/>
        /// </summary>
        /// <param name="query">Plain text or query selector or XPath search query.</param>
        /// <param name="includeUserAgentShadowDOM">True to search in user agent shadow DOM.</param>
        /// <returns></returns>
        public async Task<JObject> PerformSearchAsync(string query,bool? includeUserAgentShadowDOM)
        {
            return await CommandAsync("performSearch", 
                 new KeyValuePair<string, object>("query", query), 
                 new KeyValuePair<string, object>("includeUserAgentShadowDOM", includeUserAgentShadowDOM)
                 );
        }
    }
}
