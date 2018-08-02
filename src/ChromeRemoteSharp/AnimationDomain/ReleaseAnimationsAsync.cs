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
        /// Releases a set of animations to no longer be manipulated.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#method-releaseAnimations"/>
        /// </summary>
        /// <param name="animations">List of animation ids to seek.</param>
        /// <returns></returns>
        public async Task<JObject> ReleaseAnimationsAsync(string[] animations)
        {
            return await CommandAsync("releaseAnimations", 
                 new KeyValuePair<string, object>("animations", animations)
                 );
        }
    }
}
