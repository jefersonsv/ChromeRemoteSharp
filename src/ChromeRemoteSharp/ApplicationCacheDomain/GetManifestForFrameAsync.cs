using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.ApplicationCacheDomain
{
    public partial class ApplicationCacheDomain
    {
        /// <summary>
        /// Returns manifest URL for document in the given frame.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ApplicationCache#getManifestForFrame"/>
        /// </summary>
        /// <param name="frameId">Identifier of the frame containing document whose manifest is retrieved.</param>
        /// <returns></returns>
        public async Task<JObject> GetManifestForFrameAsync(string frameId)
        {
            return await CommandAsync("getManifestForFrame", 
                 new KeyValuePair<string, object>("frameId", frameId)
                 );
        }
    }
}
