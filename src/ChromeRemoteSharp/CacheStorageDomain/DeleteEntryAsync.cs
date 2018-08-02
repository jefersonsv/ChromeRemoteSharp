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
        /// Deletes a cache entry.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CacheStorage#method-deleteEntry"/>
        /// </summary>
        /// <param name="cacheId">Id of cache where the entry will be deleted.</param>
        /// <param name="request">URL spec of the request.</param>
        /// <returns></returns>
        public async Task<JObject> DeleteEntryAsync(string cacheId, string request)
        {
            return await CommandAsync("deleteEntry", 
                 new KeyValuePair<string, object>("cacheId", cacheId), 
                 new KeyValuePair<string, object>("request", request)
                 );
        }
    }
}
