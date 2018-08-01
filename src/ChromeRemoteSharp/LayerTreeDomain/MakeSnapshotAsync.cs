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
        /// Returns the layer snapshot identifier.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#makeSnapshot"/>
        /// </summary>
        /// <param name="layerId">The id of the layer.</param>
        /// <returns></returns>
        public async Task<JObject> MakeSnapshotAsync(string layerId)
        {
            return await CommandAsync("makeSnapshot", 
                 new KeyValuePair<string, object>("layerId", layerId)
                 );
        }
    }
}
