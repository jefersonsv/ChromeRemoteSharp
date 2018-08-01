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
        /// Releases layer snapshot captured by the back-end.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#releaseSnapshot"/>
        /// </summary>
        /// <param name="snapshotId">The id of the layer snapshot.</param>
        /// <returns></returns>
        public async Task<JObject> ReleaseSnapshotAsync(string snapshotId)
        {
            return await CommandAsync("releaseSnapshot", 
                 new KeyValuePair<string, object>("snapshotId", snapshotId)
                 );
        }
    }
}
