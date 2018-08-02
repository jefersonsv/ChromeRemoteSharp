using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.StorageDomain
{
    public partial class StorageDomain
    {
        /// <summary>
        /// Clears storage for origin.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Storage#method-clearDataForOrigin"/>
        /// </summary>
        /// <param name="origin">Security origin.</param>
        /// <param name="storageTypes">Comma separated origin names.</param>
        /// <returns></returns>
        public async Task<JObject> ClearDataForOriginAsync(string origin, string storageTypes)
        {
            return await CommandAsync("clearDataForOrigin", 
                 new KeyValuePair<string, object>("origin", origin), 
                 new KeyValuePair<string, object>("storageTypes", storageTypes)
                 );
        }
    }
}
