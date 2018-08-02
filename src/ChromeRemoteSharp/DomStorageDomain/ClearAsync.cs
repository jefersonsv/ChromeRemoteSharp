using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.DomStorageDomain
{
    public partial class DomStorageDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/DOMStorage#method-clear"/>
        /// </summary>
        /// <param name="storageId"></param>
        /// <returns></returns>
        public async Task<JObject> ClearAsync(string storageId)
        {
            return await CommandAsync("clear", 
                 new KeyValuePair<string, object>("storageId", storageId)
                 );
        }
    }
}
