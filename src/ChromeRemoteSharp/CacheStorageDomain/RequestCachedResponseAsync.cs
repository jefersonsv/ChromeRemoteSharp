using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.CacheStorageDomain
{
    public partial class CacheStorageDomain
    {
        /// <summary>
        /// Fetches cache entry.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CacheStorage#method-requestCachedResponse"/>
        /// </summary>
        /// <param name="cacheId">Id of cache that contains the enty.</param>
        /// <param name="requestURL">URL spec of the request.</param>
        /// <returns></returns>
        public async Task<JObject> RequestCachedResponseAsync(string cacheId, string requestURL)
        {
            return await CommandAsync("requestCachedResponse", 
                 new KeyValuePair<string, object>("cacheId", cacheId), 
                 new KeyValuePair<string, object>("requestURL", requestURL)
                 );
        }
    }
}
