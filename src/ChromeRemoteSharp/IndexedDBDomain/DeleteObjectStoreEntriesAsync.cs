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
        /// Delete a range of entries from an object store
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#deleteObjectStoreEntries"/>
        /// </summary>
        /// <param name="securityOrigin"></param>
        /// <param name="databaseName"></param>
        /// <param name="objectStoreName"></param>
        /// <param name="keyRange">Range of entry keys to delete</param>
        /// <returns></returns>
        public async Task<JObject> DeleteObjectStoreEntriesAsync(string securityOrigin,string databaseName,string objectStoreName,string keyRange)
        {
            return await CommandAsync("deleteObjectStoreEntries", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin), 
                 new KeyValuePair<string, object>("databaseName", databaseName), 
                 new KeyValuePair<string, object>("objectStoreName", objectStoreName), 
                 new KeyValuePair<string, object>("keyRange", keyRange)
                 );
        }
    }
}
