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
        /// Releases remote object with given id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime#releaseObject"/>
        /// </summary>
        /// <param name="objectId">Identifier of the object to release.</param>
        /// <returns></returns>
        public async Task<JObject> ReleaseObjectAsync(string objectId)
        {
            return await CommandAsync("releaseObject", 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
