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
        /// Returns usage and quota in bytes.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Storage#method-getUsageAndQuota"/>
        /// </summary>
        /// <param name="origin">Security origin.</param>
        /// <returns></returns>
        public async Task<JObject> GetUsageAndQuotaAsync(string origin)
        {
            return await CommandAsync("getUsageAndQuota", 
                 new KeyValuePair<string, object>("origin", origin)
                 );
        }
    }
}
