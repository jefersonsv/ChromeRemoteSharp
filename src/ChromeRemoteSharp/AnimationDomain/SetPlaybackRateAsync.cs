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
        /// Sets the playback rate of the document timeline.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#setPlaybackRate"/>
        /// </summary>
        /// <param name="playbackRate">Playback rate for animations on page</param>
        /// <returns></returns>
        public async Task<JObject> SetPlaybackRateAsync(int playbackRate)
        {
            return await CommandAsync("setPlaybackRate", 
                 new KeyValuePair<string, object>("playbackRate", playbackRate)
                 );
        }
    }
}
