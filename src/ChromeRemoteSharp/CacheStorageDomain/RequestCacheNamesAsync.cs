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
        /// Requests cache names.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/CacheStorage#requestCacheNames"/>
        /// </summary>
        /// <param name="securityOrigin">Security origin.</param>
        /// <returns></returns>
        public async Task<JObject> RequestCacheNamesAsync(string securityOrigin)
        {
            return await CommandAsync("requestCacheNames", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin)
                 );
        }
    }
}
