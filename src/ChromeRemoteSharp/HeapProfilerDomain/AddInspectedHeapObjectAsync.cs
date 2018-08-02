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
        /// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeapProfiler#method-addInspectedHeapObject"/>
        /// </summary>
        /// <param name="heapObjectId">Heap snapshot object id to be accessible by means of $x command line API.</param>
        /// <returns></returns>
        public async Task<JObject> AddInspectedHeapObjectAsync(string heapObjectId)
        {
            return await CommandAsync("addInspectedHeapObject", 
                 new KeyValuePair<string, object>("heapObjectId", heapObjectId)
                 );
        }
    }
}
