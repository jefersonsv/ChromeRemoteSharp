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
        /// Returns relevant application cache data for the document in given frame.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ApplicationCache#method-getApplicationCacheForFrame"/>
        /// </summary>
        /// <param name="frameId">Identifier of the frame containing document whose application cache is retrieved.</param>
        /// <returns></returns>
        public async Task<JObject> GetApplicationCacheForFrameAsync(string frameId)
        {
            return await CommandAsync("getApplicationCacheForFrame", 
                 new KeyValuePair<string, object>("frameId", frameId)
                 );
        }
    }
}
