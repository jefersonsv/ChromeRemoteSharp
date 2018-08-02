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
        /// Returns search results from given `fromIndex` to given `toIndex` from the search with the given identifier.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOM#method-getSearchResults"/>
        /// </summary>
        /// <param name="searchId">Unique search session identifier.</param>
        /// <param name="fromIndex">Start index of the search result to be returned.</param>
        /// <param name="toIndex">End index of the search result to be returned.</param>
        /// <returns></returns>
        public async Task<JObject> GetSearchResultsAsync(string searchId, string fromIndex, string toIndex)
        {
            return await CommandAsync("getSearchResults", 
                 new KeyValuePair<string, object>("searchId", searchId), 
                 new KeyValuePair<string, object>("fromIndex", fromIndex), 
                 new KeyValuePair<string, object>("toIndex", toIndex)
                 );
        }
    }
}
