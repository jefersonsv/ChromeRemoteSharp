using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain
    {
        /// <summary>
        /// Releases all remote objects that belong to a given group.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#releaseObjectGroup"/>
        /// </summary>
        /// <param name="objectGroup">Symbolic object group name.</param>
        /// <returns></returns>
        public async Task<JObject> ReleaseObjectGroupAsync(string objectGroup)
        {
            return await CommandAsync("releaseObjectGroup", 
                 new KeyValuePair<string, object>("objectGroup", objectGroup)
                 );
        }
    }
}
