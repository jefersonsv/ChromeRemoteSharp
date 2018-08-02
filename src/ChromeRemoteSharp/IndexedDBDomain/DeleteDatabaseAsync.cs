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
        /// Deletes a database.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#method-deleteDatabase"/>
        /// </summary>
        /// <param name="securityOrigin">Security origin.</param>
        /// <param name="databaseName">Database name.</param>
        /// <returns></returns>
        public async Task<JObject> DeleteDatabaseAsync(string securityOrigin, string databaseName)
        {
            return await CommandAsync("deleteDatabase", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin), 
                 new KeyValuePair<string, object>("databaseName", databaseName)
                 );
        }
    }
}
