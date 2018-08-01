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
        /// Seek a set of animations to a particular time within each animation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#seekAnimations"/>
        /// </summary>
        /// <param name="animations">List of animation ids to seek.</param>
        /// <param name="currentTime">Set the current time of each animation.</param>
        /// <returns></returns>
        public async Task<JObject> SeekAnimationsAsync(string[] animations,int currentTime)
        {
            return await CommandAsync("seekAnimations", 
                 new KeyValuePair<string, object>("animations", animations)
, 
                 new KeyValuePair<string, object>("currentTime", currentTime)
                 );
        }
    }
}
