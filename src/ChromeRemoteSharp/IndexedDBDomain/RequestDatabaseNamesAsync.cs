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
        /// Requests database names for given security origin.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IndexedDB#requestDatabaseNames"/>
        /// </summary>
        /// <param name="securityOrigin">Security origin.</param>
        /// <returns></returns>
        public async Task<JObject> RequestDatabaseNamesAsync(string securityOrigin)
        {
            return await CommandAsync("requestDatabaseNames", 
                 new KeyValuePair<string, object>("securityOrigin", securityOrigin)
                 );
        }
    }
}
