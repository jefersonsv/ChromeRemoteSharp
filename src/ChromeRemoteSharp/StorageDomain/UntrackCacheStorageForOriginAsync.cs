using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.StorageDomain
{
    public partial class StorageDomain
    {
        /// <summary>
        /// Unregisters origin from receiving notifications for cache storage.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Storage#untrackCacheStorageForOrigin"/>
        /// </summary>
        /// <param name="origin">Security origin.</param>
        /// <returns></returns>
        public async Task<JObject> UntrackCacheStorageForOriginAsync(string origin)
        {
            return await CommandAsync("untrackCacheStorageForOrigin", 
                 new KeyValuePair<string, object>("origin", origin)
                 );
        }
    }
}
