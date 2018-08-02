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
        /// Provides the reasons why the given layer was composited.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#method-compositingReasons"/>
        /// </summary>
        /// <param name="layerId">The id of the layer for which we want to get the reasons it was composited.</param>
        /// <returns></returns>
        public async Task<JObject> CompositingReasonsAsync(string layerId)
        {
            return await CommandAsync("compositingReasons", 
                 new KeyValuePair<string, object>("layerId", layerId)
                 );
        }
    }
}
