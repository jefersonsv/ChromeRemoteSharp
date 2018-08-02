using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.LayerTreeDomain
{
    public partial class LayerTreeDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#method-profileSnapshot"/>
        /// </summary>
        /// <param name="snapshotId">The id of the layer snapshot.</param>
        /// <param name="minRepeatCount">The maximum number of times to replay the snapshot (1, if not specified).</param>
        /// <param name="minDuration">The minimum duration (in seconds) to replay the snapshot.</param>
        /// <param name="clipRect">The clip rectangle to apply when replaying the snapshot.</param>
        /// <returns></returns>
        public async Task<JObject> ProfileSnapshotAsync(string snapshotId, string minRepeatCount = null, int? minDuration = null, string clipRect = null)
        {
            return await CommandAsync("profileSnapshot", 
                 new KeyValuePair<string, object>("snapshotId", snapshotId), 
                 new KeyValuePair<string, object>("minRepeatCount", minRepeatCount), 
                 new KeyValuePair<string, object>("minDuration", minDuration), 
                 new KeyValuePair<string, object>("clipRect", clipRect)
                 );
        }
    }
}
