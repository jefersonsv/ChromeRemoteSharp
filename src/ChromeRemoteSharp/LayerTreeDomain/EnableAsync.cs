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
        /// Enables compositing tree inspection.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree#method-enable"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> EnableAsync()
        {
            return await CommandAsync("enable");
        }
    }
}
