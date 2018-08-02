using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.AnimationDomain
{
    public partial class AnimationDomain
    {
        /// <summary>
        /// Gets the playback rate of the document timeline.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#method-getPlaybackRate"/>
        /// </summary>

        /// <returns></returns>
        public async Task<JObject> GetPlaybackRateAsync()
        {
            return await CommandAsync("getPlaybackRate");
        }
    }
}
