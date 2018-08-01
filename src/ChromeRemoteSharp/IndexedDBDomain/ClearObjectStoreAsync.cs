using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.IndexedDBDomain
{
    public partial class IndexedDBDomain
    {
        /// <summary>
        /// Clears all entries from an object store.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#clearObjectStore"/>
        /// </summary>
        /// <param name="securityOrigin">Security origin.</param>
        /// <param name="databaseName">Database name.</param>
        /// <param name="objectStoreName">Object store name.</param>
        /// <returns></returns>
        public async Task<JObject> ClearObjectStoreAsync(string securityOrigin,string databaseName,string objectStoreName)
        {
            return await CommandAsync("clearObjectStore", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin), 
                 new KeyValuePair<string, object>("databaseName", databaseName), 
                 new KeyValuePair<string, object>("objectStoreName", objectStoreName)
                 );
        }
    }
}
