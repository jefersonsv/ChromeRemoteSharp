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
        /// Replays the layer snapshot and returns the resulting bitmap.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#method-replaySnapshot"/>
        /// </summary>
        /// <param name="snapshotId">The id of the layer snapshot.</param>
        /// <param name="fromStep">The first step to replay from (replay from the very start if not specified).</param>
        /// <param name="toStep">The last step to replay to (replay till the end if not specified).</param>
        /// <param name="scale">The scale to apply while replaying (defaults to 1).</param>
        /// <returns></returns>
        public async Task<JObject> ReplaySnapshotAsync(string snapshotId, string fromStep = null, string toStep = null, int? scale = null)
        {
            return await CommandAsync("replaySnapshot", 
                 new KeyValuePair<string, object>("snapshotId", snapshotId), 
                 new KeyValuePair<string, object>("fromStep", fromStep), 
                 new KeyValuePair<string, object>("toStep", toStep), 
                 new KeyValuePair<string, object>("scale", scale)
                 );
        }
    }
}
