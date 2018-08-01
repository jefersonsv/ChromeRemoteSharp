using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomStorageDomain
{
    public partial class DomStorageDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DomStorage#removeDOMStorageItem"/>
        /// </summary>
        /// <param name="storageId"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<JObject> RemoveDOMStorageItemAsync(string storageId,string key)
        {
            return await CommandAsync("removeDOMStorageItem", 
                 new KeyValuePair<string, object>("storageId", storageId), 
                 new KeyValuePair<string, object>("key", key)
                 );
        }
    }
}
