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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMStorage#method-setDOMStorageItem"/>
        /// </summary>
        /// <param name="storageId"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task<JObject> SetDOMStorageItemAsync(string storageId, string key, string value)
        {
            return await CommandAsync("setDOMStorageItem", 
                 new KeyValuePair<string, object>("storageId", storageId), 
                 new KeyValuePair<string, object>("key", key), 
                 new KeyValuePair<string, object>("value", value)
                 );
        }
    }
}
