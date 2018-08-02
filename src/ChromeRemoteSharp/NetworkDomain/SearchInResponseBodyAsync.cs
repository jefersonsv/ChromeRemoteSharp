using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// Searches for given string in response content.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#method-searchInResponseBody"/>
        /// </summary>
        /// <param name="requestId">Identifier of the network response to search.</param>
        /// <param name="query">String to search for.</param>
        /// <param name="caseSensitive">If true, search is case sensitive.</param>
        /// <param name="isRegex">If true, treats string parameter as regex.</param>
        /// <returns></returns>
        public async Task<JObject> SearchInResponseBodyAsync(string requestId, string query, bool? caseSensitive = null, bool? isRegex = null)
        {
            return await CommandAsync("searchInResponseBody", 
                 new KeyValuePair<string, object>("requestId", requestId), 
                 new KeyValuePair<string, object>("query", query), 
                 new KeyValuePair<string, object>("caseSensitive", caseSensitive), 
                 new KeyValuePair<string, object>("isRegex", isRegex)
                 );
        }
    }
}
