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
        /// Deletes a cache.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CacheStorage#deleteCache"/>
        /// </summary>
        /// <param name="cacheId">Id of cache for deletion.</param>
        /// <returns></returns>
        public async Task<JObject> DeleteCacheAsync(string cacheId)
        {
            return await CommandAsync("deleteCache", 
                 new KeyValuePair<string, object>("cacheId", cacheId)
                 );
        }
    }
}
