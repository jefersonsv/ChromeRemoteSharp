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
        /// Requests database with given name in given frame.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#requestDatabase"/>
        /// </summary>
        /// <param name="securityOrigin">Security origin.</param>
        /// <param name="databaseName">Database name.</param>
        /// <returns></returns>
        public async Task<JObject> RequestDatabaseAsync(string securityOrigin,string databaseName)
        {
            return await CommandAsync("requestDatabase", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin), 
                 new KeyValuePair<string, object>("databaseName", databaseName)
                 );
        }
    }
}
