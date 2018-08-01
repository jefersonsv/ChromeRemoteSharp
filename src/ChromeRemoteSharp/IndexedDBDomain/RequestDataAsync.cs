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
        /// Requests data from object store or index.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#requestData"/>
        /// </summary>
        /// <param name="securityOrigin">Security origin.</param>
        /// <param name="databaseName">Database name.</param>
        /// <param name="objectStoreName">Object store name.</param>
        /// <param name="indexName">Index name, empty string for object store data requests.</param>
        /// <param name="skipCount">Number of records to skip.</param>
        /// <param name="pageSize">Number of records to fetch.</param>
        /// <param name="keyRange">Key range.</param>
        /// <returns></returns>
        public async Task<JObject> RequestDataAsync(string securityOrigin,string databaseName,string objectStoreName,string indexName,string skipCount,string pageSize,string keyRange)
        {
            return await CommandAsync("requestData", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin), 
                 new KeyValuePair<string, object>("databaseName", databaseName), 
                 new KeyValuePair<string, object>("objectStoreName", objectStoreName), 
                 new KeyValuePair<string, object>("indexName", indexName), 
                 new KeyValuePair<string, object>("skipCount", skipCount), 
                 new KeyValuePair<string, object>("pageSize", pageSize), 
                 new KeyValuePair<string, object>("keyRange", keyRange)
                 );
        }
    }
}
