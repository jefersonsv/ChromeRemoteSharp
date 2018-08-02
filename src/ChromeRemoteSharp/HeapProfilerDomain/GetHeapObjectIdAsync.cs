using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.HeapProfilerDomain
{
    public partial class HeapProfilerDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#method-getHeapObjectId"/>
        /// </summary>
        /// <param name="objectId">Identifier of the object to get heap object id for.</param>
        /// <returns></returns>
        public async Task<JObject> GetHeapObjectIdAsync(string objectId)
        {
            return await CommandAsync("getHeapObjectId", 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
