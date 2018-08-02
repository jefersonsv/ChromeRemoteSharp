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
        /// Requests data from cache.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CacheStorage#method-requestEntries"/>
        /// </summary>
        /// <param name="cacheId">ID of cache to get entries from.</param>
        /// <param name="skipCount">Number of records to skip.</param>
        /// <param name="pageSize">Number of records to fetch.</param>
        /// <returns></returns>
        public async Task<JObject> RequestEntriesAsync(string cacheId, string skipCount, string pageSize)
        {
            return await CommandAsync("requestEntries", 
                 new KeyValuePair<string, object>("cacheId", cacheId), 
                 new KeyValuePair<string, object>("skipCount", skipCount), 
                 new KeyValuePair<string, object>("pageSize", pageSize)
                 );
        }
    }
}
