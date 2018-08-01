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
        /// Searches for given string in resource content.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#searchInResource"/>
        /// </summary>
        /// <param name="frameId">Frame id for resource to search in.</param>
        /// <param name="url">URL of the resource to search in.</param>
        /// <param name="query">String to search for.</param>
        /// <param name="caseSensitive">If true, search is case sensitive.</param>
        /// <param name="isRegex">If true, treats string parameter as regex.</param>
        /// <returns></returns>
        public async Task<JObject> SearchInResourceAsync(string frameId,string url,string query,bool? caseSensitive,bool? isRegex)
        {
            return await CommandAsync("searchInResource", 
                 new KeyValuePair<string, object>("frameId", frameId), 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("query", query), 
                 new KeyValuePair<string, object>("caseSensitive", caseSensitive), 
                 new KeyValuePair<string, object>("isRegex", isRegex)
                 );
        }
    }
}
