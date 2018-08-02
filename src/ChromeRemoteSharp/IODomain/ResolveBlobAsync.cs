using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.IODomain
{
    public partial class IODomain
    {
        /// <summary>
        /// Return UUID of Blob object specified by a remote object id.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/IO#method-resolveBlob"/>
        /// </summary>
        /// <param name="objectId">Object id of a Blob object wrapper.</param>
        /// <returns></returns>
        public async Task<JObject> ResolveBlobAsync(string objectId)
        {
            return await CommandAsync("resolveBlob", 
                 new KeyValuePair<string, object>("objectId", objectId)
                 );
        }
    }
}
