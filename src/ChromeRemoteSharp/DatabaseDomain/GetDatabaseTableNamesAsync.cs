using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DatabaseDomain
{
    public partial class DatabaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Database#method-getDatabaseTableNames"/>
        /// </summary>
        /// <param name="databaseId"></param>
        /// <returns></returns>
        public async Task<JObject> GetDatabaseTableNamesAsync(string databaseId)
        {
            return await CommandAsync("getDatabaseTableNames", 
                 new KeyValuePair<string, object>("databaseId", databaseId)
                 );
        }
    }
}
