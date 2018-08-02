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
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#method-getObjectByHeapObjectId"/>
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="objectGroup">Symbolic group name that can be used to release multiple objects.</param>
        /// <returns></returns>
        public async Task<JObject> GetObjectByHeapObjectIdAsync(string objectId, string objectGroup = null)
        {
            return await CommandAsync("getObjectByHeapObjectId", 
                 new KeyValuePair<string, object>("objectId", objectId), 
                 new KeyValuePair<string, object>("objectGroup", objectGroup)
                 );
        }
    }
}
