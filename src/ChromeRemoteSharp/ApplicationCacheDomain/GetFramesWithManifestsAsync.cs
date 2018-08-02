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
        /// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/ApplicationCache#method-getFramesWithManifests"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetFramesWithManifestsAsync()
        {
            return await CommandAsync("getFramesWithManifests");
        }
    }
}
