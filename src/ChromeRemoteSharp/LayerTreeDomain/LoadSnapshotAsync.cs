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
        /// Returns the snapshot identifier.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#method-loadSnapshot"/>
        /// </summary>
        /// <param name="tiles">An array of tiles composing the snapshot.</param>
        /// <returns></returns>
        public async Task<JObject> LoadSnapshotAsync(string[] tiles)
        {
            return await CommandAsync("loadSnapshot", 
                 new KeyValuePair<string, object>("tiles", tiles)
                 );
        }
    }
}
