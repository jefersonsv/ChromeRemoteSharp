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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Database#method-executeSQL"/>
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<JObject> ExecuteSQLAsync(string databaseId, string query)
        {
            return await CommandAsync("executeSQL", 
                 new KeyValuePair<string, object>("databaseId", databaseId), 
                 new KeyValuePair<string, object>("query", query)
                 );
        }
    }
}
