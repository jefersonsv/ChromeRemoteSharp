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
        /// Discards search results from the session with the given id. `getSearchResults` should no longer be called for that search.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-discardSearchResults"/>
        /// </summary>
        /// <param name="searchId">Unique search session identifier.</param>
        /// <returns></returns>
        public async Task<JObject> DiscardSearchResultsAsync(string searchId)
        {
            return await CommandAsync("discardSearchResults", 
                 new KeyValuePair<string, object>("searchId", searchId)
                 );
        }
    }
}
