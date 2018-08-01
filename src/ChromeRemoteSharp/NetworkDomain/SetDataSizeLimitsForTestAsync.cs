using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.NetworkDomain
{
    public partial class NetworkDomain
    {
        /// <summary>
        /// For testing.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Network#setDataSizeLimitsForTest"/>
        /// </summary>
        /// <param name="maxTotalSize">Maximum total buffer size.</param>
        /// <param name="maxResourceSize">Maximum per-resource size.</param>
        /// <returns></returns>
        public async Task<JObject> SetDataSizeLimitsForTestAsync(string maxTotalSize,string maxResourceSize)
        {
            return await CommandAsync("setDataSizeLimitsForTest", 
                 new KeyValuePair<string, object>("maxTotalSize", maxTotalSize), 
                 new KeyValuePair<string, object>("maxResourceSize", maxResourceSize)
                 );
        }
    }
}
