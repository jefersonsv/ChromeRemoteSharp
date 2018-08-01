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
        /// Registers origin to be notified when an update occurs to its cache storage list.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Storage#trackCacheStorageForOrigin"/>
        /// </summary>
        /// <param name="origin">Security origin.</param>
        /// <returns></returns>
        public async Task<JObject> TrackCacheStorageForOriginAsync(string origin)
        {
            return await CommandAsync("trackCacheStorageForOrigin", 
                 new KeyValuePair<string, object>("origin", origin)
                 );
        }
    }
}
