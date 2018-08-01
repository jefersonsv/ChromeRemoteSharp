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
        /// Gets the remote object of the Animation.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation#resolveAnimation"/>
        /// </summary>
        /// <param name="animationId">Animation id.</param>
        /// <returns></returns>
        public async Task<JObject> ResolveAnimationAsync(string animationId)
        {
            return await CommandAsync("resolveAnimation", 
                 new KeyValuePair<string, object>("animationId", animationId)
                 );
        }
    }
}
