using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DebuggerDomain
{
    public partial class DebuggerDomain
    {
        /// <summary>
        /// Searches for given string in script content.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Debugger#method-searchInContent"/>
        /// </summary>
        /// <param name="scriptId">Id of the script to search in.</param>
        /// <param name="query">String to search for.</param>
        /// <param name="caseSensitive">If true, search is case sensitive.</param>
        /// <param name="isRegex">If true, treats string parameter as regex.</param>
        /// <returns></returns>
        public async Task<JObject> SearchInContentAsync(string scriptId, string query, bool? caseSensitive = null, bool? isRegex = null)
        {
            return await CommandAsync("searchInContent", 
                 new KeyValuePair<string, object>("scriptId", scriptId), 
                 new KeyValuePair<string, object>("query", query), 
                 new KeyValuePair<string, object>("caseSensitive", caseSensitive), 
                 new KeyValuePair<string, object>("isRegex", isRegex)
                 );
        }
    }
}
