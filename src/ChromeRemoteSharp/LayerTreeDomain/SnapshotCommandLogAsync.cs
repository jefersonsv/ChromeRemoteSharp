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
        /// Replays the layer snapshot and returns canvas log.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#method-snapshotCommandLog"/>
        /// </summary>
        /// <param name="snapshotId">The id of the layer snapshot.</param>
        /// <returns></returns>
        public async Task<JObject> SnapshotCommandLogAsync(string snapshotId)
        {
            return await CommandAsync("snapshotCommandLog", 
                 new KeyValuePair<string, object>("snapshotId", snapshotId)
                 );
        }
    }
}
