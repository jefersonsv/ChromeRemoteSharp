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
        /// Seeds compilation cache for given url. Compilation cache does not survive cross-process navigation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#addCompilationCache"/>
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data">Base64-encoded data</param>
        /// <returns></returns>
        public async Task<JObject> AddCompilationCacheAsync(string url,string data)
        {
            return await CommandAsync("addCompilationCache", 
                 new KeyValuePair<string, object>("url", url), 
                 new KeyValuePair<string, object>("data", data)
                 );
        }
    }
}
